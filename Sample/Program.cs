using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityCloudBuildApi.IO.Swagger.Client;
using UnityCloudBuildApi.IO.Swagger.Model;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiKey = "INPUT YOUR APIKEY"; // You may find from https://build.cloud.unity3d.com/login/me/
            var orgId = "INPUT YOUR ORGNAME";
            var projectId = "INPUT TARGET PROJECT ID"; // you may find from https://build.cloud.unity3d.com/orgs/<ORGNAME>/projects/<PROJECTNAME>/

            var client = new ApiClient("https://build-api.cloud.unity3d.com/api/v1");
            var config = new Configuration(client, accessToken: apiKey);

            var targetBuilds = TestBuildTargetApi(config, orgId, projectId).Result;
            var buildOperation = TestBuildOperationApi(config, orgId, projectId, targetBuilds);
        }

        static async Task<List<InlineResponse2003>> TestBuildTargetApi(Configuration config, string orgId, string projectId)
        {
            #region BuildTarget Api

            // Get BuildTargets for list BuildTargetId
            var buildTargetApi = new UnityCloudBuildApi.IO.Swagger.Api.BuildtargetsApi(config);
            var buildTargets = await buildTargetApi.GetBuildTargetsAsync(orgId, projectId);
            var hoge = buildTargets.Select(x => x.ToJson()).ToArray();

            // Get BuildTarget Info
            var buildTarget = await buildTargetApi.GetBuildTargetAsync(orgId, projectId, buildTargets.FirstOrDefault().Buildtargetid);
            var fuga = buildTarget.ToJson();

            #endregion

            return buildTargets;
        }

        #region Build Api

        static async Task TestBuildOperationApi(Configuration config, string orgId, string projectId, List<InlineResponse2003> buildTargets)
        {
            // Get Build Detail
            var buildApi = new UnityCloudBuildApi.IO.Swagger.Api.BuildsApi(config);
            var build = await buildApi.GetBuildsAsync(orgId, projectId, buildTargets.FirstOrDefault().Buildtargetid);
            var piyo = build.Select(x => x.ToJson());

            // Start Build
            var option = new UnityCloudBuildApi.IO.Swagger.Model.Options4
            {
                Clean = false,
                Delay = 0,
            };
            var startBuild = await buildApi.StartBuildsAsync(orgId, projectId, buildTargets.FirstOrDefault().Buildtargetid, option);
            var poyo = startBuild.Select(x => x.ToJson());

            // Cancel All queued Build
            foreach (var item in build.Where(x => x.BuildStatus == "queued"))
            {
                var cancelBuilds = await buildApi.CancelAllBuildsAsync(orgId, projectId, item.Buildtargetid);
                var koko = cancelBuilds.Select(x => x.ToString());
            }

            // Cancel Specific Builds
            var cancelBuild = await buildApi.CancelBuildAsync(orgId, projectId, buildTargets.FirstOrDefault().Buildtargetid, startBuild.FirstOrDefault().Build.ToString());

            #endregion
        }
    }
}

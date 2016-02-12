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

            var targetProject = TestProjectApi(config, orgId).Result;
            var targetBuilds = TestBuildTargetApi(config, orgId, projectId).Result;
            var buildOperation = TestBuildOperationApi(config, orgId, projectId, targetBuilds);
        }


        static async Task<InlineResponse2001> TestProjectApi(Configuration config, string orgId)
        {
            #region Project Api

            // Add Project
            var projectApi = new UnityCloudBuildApi.IO.Swagger.Api.ProjectsApi(config);
            var options = new Options
            {
                Name = "Test",
                Settings = new OrgsorgidprojectsSettings
                {
                    Scm = new OrgsorgidprojectsSettingsScm
                    {
                        Url = "https://github.com/username/repositoryname.git",
                        Type = "git",
                        User = "github user name",
                        Pass = "github api token",
                    },
                },
            };
            var addProject = await projectApi.AddProjectAsync(orgId, options);
            var hoge = addProject.ToJson();

            // Get Project
            var proejct = await projectApi.GetBillingPlansAsync(orgId, addProject.Projectid);
            var fuga = proejct.ToJson();

            // List Project
            var listProject = await projectApi.ListProjectsForOrgAsync(orgId);
            var piyo = listProject.Select(x => x.ToJson()).ToArray();

            return addProject;

            #endregion
        }


        static async Task<List<InlineResponse2003>> TestBuildTargetApi(Configuration config, string orgId, string projectId)
        {
            #region BuildTarget Api

            // Add Build Target
            var buildTargetApi = new UnityCloudBuildApi.IO.Swagger.Api.BuildtargetsApi(config);
            var option2 = new Options2
            {
                Platform = "android",
                Name = "Test",
                Enabled = false,
                Settings = new OrgsorgidprojectsprojectidbuildtargetsSettings
                {
                    Platform = new OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform { BundleId = "com.hoge.fuga" },
                    AutoBuild = true,
                    Scm = new OrgsorgidprojectsprojectidbuildtargetsSettingsScm
                    {
                        Branch = "master",
                        Type = "git"
                    },
                    UnityVersion = "latest",
                },
            };
            var newBuildTarget = await buildTargetApi.AddBuildTargetAsync(orgId, projectId, option2);
            var hoge = newBuildTarget.ToJson();

            // Get BuildTargets for list BuildTargetId
            var buildTargets = await buildTargetApi.GetBuildTargetsAsync(orgId, projectId);
            var fuga = buildTargets.Select(x => x.ToJson()).ToArray();

            // Get BuildTarget Info
            var buildTarget = await buildTargetApi.GetBuildTargetAsync(orgId, projectId, buildTargets.FirstOrDefault().Buildtargetid);
            var piyo = buildTarget.ToJson();

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
            var option = new Options4
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

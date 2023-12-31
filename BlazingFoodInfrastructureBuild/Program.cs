﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;


var adotNetClient = new ADotNetClient();

var gitHubPipline = new GithubPipeline{
Name = "Blazing Food Build",

OnEvents = new Events 
{
    PullRequest = new PullRequestEvent{
        Branches = new string[] { "main"}
    },

    Push = new PushEvent
    {
        Branches = new string[]{"main"}
    }
},
    Jobs = new Jobs
    {
        Build = new BuildJob
        {
            RunsOn = BuildMachines.WindowsLatest,

            Steps = new List<GithubTask>
            {
               new CheckoutTaskV2
               {
                 Name = "Checking out code"
               },

               new SetupDotNetTaskV1
               {
                Name = "Instelling .NET",
                TargetDotNetVersion = new TargetDotNetVersion
                {
                    DotNetVersion = "6.0.411"
                }
               },

               new RestoreTask
               {
                Name = "Restoring Nuget Packages"
               },

               new DotNetBuildTask
               {
                Name = "Building Project"
               },

               new TestTask
               {
                Name = "Running Tests"
               },

            },

        }
    }


};

adotNetClient.SerializeAndWriteToFile(
    adoPipeline: gitHubPipline,
    path: "../../../../.github/workflows/dotnet.yml");
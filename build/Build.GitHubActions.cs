using Nuke.Common.CI.GitHubActions;

[GitHubActions("Dovign.Logging-CI",
    GitHubActionsImage.UbuntuLatest,
    OnPushBranches = ["main"],
    InvokedTargets = [nameof(Compile)])]

[GitHubActions("Dovign.Logging-PR",
    GitHubActionsImage.UbuntuLatest,
    OnPullRequestBranches = ["main", "releases/**"],
    InvokedTargets = [nameof(Compile)])]

[GitHubActions("Dovign.Logging-Release",
    GitHubActionsImage.UbuntuLatest,
    On = [GitHubActionsTrigger.WorkflowDispatch],
    InvokedTargets = [nameof(PublishLogging)],
    ImportSecrets = [nameof(DovignNugetApiKey)],
    PublishArtifacts = true)]

partial class Build;

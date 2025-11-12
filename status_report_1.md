# Status Report 1

## Accomplishments
- **Aman:** Aman has added the base project files and created a title scene for the game. [Commit link](https://github.ncsu.edu/mbanas/sheep-project/commit/6a0672cbc3a974fff6070a5ca64d83594bdc60d2)
    He also updated the Github repository settings to include branch protection for the main branch. In addition, he added a workflow to run the CSharpier formatter to check code formatting and style across the project.
- **Andrew:** Andrew has added GoDotTest to the project dependencies to prepare for unit testing. He also added a basic .NET build & test workflow to see how we might be able to use GitHub Actions in CI/CD. [Commit link](https://github.ncsu.edu/mbanas/sheep-project/commit/9e18cf99543e890eaabc78cc62112437012cd2b2)

## Next steps
- **Aman:** In the next sprint, Aman plans to continue working on the Github Actions runners and pipeline to ensure they build correctly (estimated to take 2-3 days). After that, he plans to work on the deployment section of the Ansible playbook, which will be responsible for confirming the required Godot and .NET versions are set up on the target machine. This will likely take around 4 days.
- **Andrew:** In the next sprint, Andrew plans to set up the Ansible playbook for the deployment part of the pipeline, in addition to adding the infrastructure for the linting step. It is expected that the Ansible playbook will take 3–5 days and the linting step will also take at least 3 days.

## Retrospective
- **Aman:** In this first part of the project, I had a few issues setting up the development environment and configuring the .NET version to use in the project. In addition, there were some bugs in the initial project implementation that needed to be fixed before the project could be tested and run. For the next sprint, Aman will start the implementation work earlier to get a better idea of what parts of the project will take the most time.
- **Andrew:** Andrew had some troubles getting his environment set up and found a resource usage concern with the title screen, but has the project dependencies set up and found a workaround for cycling through the debug menu to monitor performance metrics. He had also planned on adding branch protection and GitHub Actions runners before realizing he didn't have access to those settings on NC State's GitHub Enterprise instance. For the next sprint, he plans to "begin with the end in mind" and resolve access issues before investing time in learning about how to accomplish a task.

## Claude Code Specifics

- This code is started as a first demonstration on how to build a C# MAUI application.
- The project can be used to build applications that can be deployed to Windows, iOS devices, Android devices, etc.
- To start, this project should be able to showcase weather to its users.
- Users may add as many locations as desired (up to 5).  This is only meant to build a good quality user experience.  DO NOT UPLOAD LOCATIONS OR PII TO A CLOUD DATABASE.
- You may create your own assets to represent weather states.  DO NOT USE COPYRIGHTED WORKS.
- You may add a map service so it only fetches current position on demand.  Render the user's location through some image.
- Verify your work through unit tests and integration tests.  Plan out how you would weigh in code coverage metrics.  Plan (but do not implement YET) for security testing and for performance testing.  Document those plans and describe what we can do.
- Create configurations as needed.  Create docs and place in a Documentation folder as needed.
- Document the purpose of the application in the README.md.  If the topics are large (> 1 page), then create a new doc and link to the README.
- Ensure this project is ready for CI/CD deployment.  For now, just expect to kick off builds when there's a need to update the main branch.  Consider planning for production deployment in the future.
- When your changes are ready, create/update an AGENTS.md to provide guidance for future AI coding agents and new contributors.  CLAUDE.md imports the AGENTS.md file.  DO NOT COMMIT SECRETS, .env FILES, OR ARTIFACTS.
- Document Invariants and how they are handled.  

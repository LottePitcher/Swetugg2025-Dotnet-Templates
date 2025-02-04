# Template Guidance

## Source Name

The source name in `template.json` is set to `Demo.Project`

The templating engine will rename any folder or file whose name contains `Demo.Project` replacing it with the provided name. 

The templating engine will replace the text in any file as follows:

- `Demo.Project` with the safe namespace for the provided name
- `Demo_Project` with the safe default class name for the provided name
- `demo.project` with the safe namespace for the provided name, in lower case
- `demo_project` with the safe default class name for the provided name, in lower case

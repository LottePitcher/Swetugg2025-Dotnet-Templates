# Template Guidance

## Source Name

The source name in `template.json` is set to `Demo.Solution`

The templating engine will rename any folder or file whose name contains `Demo.Solution` replacing it with the provided name. 

The templating engine will replace the text in any file as follows:

- `Demo.Solution` with the safe namespace for the provided name
- `Demo_Solution` with the safe default class name for the provided name
- `demo.solution` with the safe namespace for the provided name, in lower case
- `demo_solution` with the safe default class name for the provided name, in lower case

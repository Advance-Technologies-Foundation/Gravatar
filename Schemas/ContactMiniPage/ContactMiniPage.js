define("ContactMiniPage", [], function() {
	return {
		entitySchemaName: "",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "HeaderContainer",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "Name",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "Account",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "merge",
				"name": "JobTitle",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4
					}
				}
			},
			{
				"operation": "merge",
				"name": "Department",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5
					}
				}
			},
			{
				"operation": "merge",
				"name": "MobilePhone",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 6
					}
				}
			},
			{
				"operation": "merge",
				"name": "Email",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "TimezoneMiniContactPage",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 9
					}
				}
			},
			{
				"operation": "move",
				"name": "TimezoneMiniContactPage",
				"parentName": "MiniPage",
				"propertyName": "items",
				"index": 7
			},
			{
				"operation": "merge",
				"name": "JobInfoContainer",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 10
					}
				}
			},
			{
				"operation": "remove",
				"name": "Type"
			},
			{
				"operation": "remove",
				"name": "OwnerEdit"
			},
			{
				"operation": "remove",
				"name": "Owner"
			},
			{
				"operation": "remove",
				"name": "OwnerButtonContainer"
			},
			{
				"operation": "remove",
				"name": "OwnerCallButton"
			},
			{
				"operation": "remove",
				"name": "OwnerEmailButton"
			}
		]/**SCHEMA_DIFF*/
	};
});

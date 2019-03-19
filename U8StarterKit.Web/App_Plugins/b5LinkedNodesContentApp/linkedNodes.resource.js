angular.module('umbraco.resources').factory('b5LinkedNodesResource',
    function ($q, $http, umbRequestHelper) {
        return {
            getLinkedNodes: function (currentId, isContent) {
                return umbRequestHelper.resourcePromise(
                    $http.get("backoffice/b5LinkedNodes/b5LinkedNodesContentAppApi/GetLinkedNodes?currentUdi="
                        + currentId + "&isContent=" + isContent),
                    "Failed to retrieve linked nodes for this node");
            }
        };
    }
);


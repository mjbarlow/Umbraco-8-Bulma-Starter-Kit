angular.module("umbraco")
.controller("b5.LinkedNodesContentApp", function ($scope, editorState, b5LinkedNodesResource) {
    var vm = this;
    vm.CurrentNodeId = editorState.current.udi;
    vm.IsContent = (editorState.current.mediaLink === undefined);

    vm.LinkedNodes = [];
 
    b5LinkedNodesResource.getLinkedNodes(vm.CurrentNodeId, vm.IsContent).then(function (response) {
        vm.LinkedNodes = response;

        vm.Count = response.length;

        $scope.model.badge = {
            count: vm.Count,
            type: "warning"
        };
    });
});
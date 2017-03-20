(function () {
    'use strict';

    app.controller("LivroController", [
        "$scope", "LivroService", function ($scope, LivroService) {

            $scope.salvar = function () {
                if (!$scope.livroEmEdicao.Id)
                    $scope.livroEmEdicao.Id = 0;

                LivroService.adicionar($scope.livroEmEdicao
                        , function (response) {
                            alert('Livro salvo com sucesso!');
                            obterTodos();
                            limpar();
                        },
                        function (error) {
                            alert('Ocorreu um erro ao salvar o livro!');
                        });
            };

            $scope.editar = function (livro) {
                $scope.livroEmEdicao = angular.copy(livro);
            };

            $scope.cancelar = function () {
                limpar();
            };

            $scope.remover = function (livro) {
                if (!confirm('Deseja realmente remover o livro?')) {
                    return;
                }

                LivroService.remover(livro
                        , function (response) {
                            alert('Livro removido com sucesso!');
                            obterTodos();
                        },
                        function (error) {
                            alert('Ocorreu um erro ao remover o livro!');
                        });
            };

            function limpar() {
                $scope.livroEmEdicao = {};
            }

            function obterTodos() {
                LivroService.obterTodos({}
                ,function (data) {
                    $scope.livros = data;
                });
            }

            function init() {
                obterTodos();
            }

            init();
        }
    ]);

})();
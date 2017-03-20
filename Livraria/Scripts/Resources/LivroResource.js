app.factory("LivroService", ['$resource', function ($resource) {
    return $resource("http://localhost:54237/api/Livro/:action/:id", {
        action: "@action"
    },
    {
        obterTodos: {
            method: 'GET',
            params: { action: 'ObterTodos' },
            isArray: true
        },

        remover: {
            method: 'POST',
            params: { action: 'Remover' },
            isArray: false
        },
        
        adicionar: {
            method: 'POST',
            params: { action: 'Adicionar' },
            isArray: false
        }
    });
}]);
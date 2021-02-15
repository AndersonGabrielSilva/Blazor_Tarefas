window.MostraAlerta = (message) => {
    alert(message);
}

//Forma de chamar um metodo estatico do C# pelo JavaScript
function getTotalTarefas() {
    DotNet.invokeMethodAsync("Blazor_Tarefas", "ObterTotalTarefa")
        .then(resultado => {
            alert("Total de Tarefas : " + resultado);
        });
}

function getTotalTarefasIntancia(dotnet) {
    return dotnet.invokeMethodAsync("ObterTotalTarefasInstancia")
        .then(resultado => {
            alert("Total de Tarefas : " + resultado);
        });
}


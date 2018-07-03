namespace SPA2

open WebSharper
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI
open WebSharper.UI.Client
open WebSharper.UI.Templating
open Library1

[<JavaScript>]
module Client =
    // The templates are loaded from the DOM, so you just can edit index.html
    // and refresh your browser, no need to recompile unless you add or remove holes.
    type IndexTemplate = Template<"index.html", ClientLoad.FromDocument>

    let People =
        ListModel.FromSeq [
            "John"
            "Paul"
        ]

    [<JavaScriptExport>]
    let usedIn2Export() =
        UsedIn2().X

    [<JavaScriptExport>]
    let usedIn1And2Export() =
        UsedIn1And2().X

    [<JavaScriptExport>]
    let usedIndirectlyIn2() =
        SPA1.Client.usedIndirectlyIn2()

namespace SPA1

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
    let usedIn1Export() =
        UsedIn1().X

    [<JavaScriptExport>]
    let usedIn1And2Export() =
        UsedIn1And2().X

    [<JavaScript>]
    let usedIndirectlyIn2() =
        UsedIndirectlyIn2().X

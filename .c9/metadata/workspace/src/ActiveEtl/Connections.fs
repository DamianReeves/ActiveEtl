{"filter":false,"title":"Connections.fs","tooltip":"/src/ActiveEtl/Connections.fs","undoManager":{"mark":11,"position":11,"stack":[[{"group":"doc","deltas":[{"start":{"row":0,"column":29},"end":{"row":0,"column":30},"action":"insert","lines":["."]}]}],[{"group":"doc","deltas":[{"start":{"row":0,"column":30},"end":{"row":0,"column":31},"action":"insert","lines":["D"]}]}],[{"group":"doc","deltas":[{"start":{"row":0,"column":31},"end":{"row":0,"column":32},"action":"insert","lines":["a"]}]}],[{"group":"doc","deltas":[{"start":{"row":0,"column":32},"end":{"row":0,"column":33},"action":"insert","lines":["t"]}]}],[{"group":"doc","deltas":[{"start":{"row":0,"column":33},"end":{"row":0,"column":34},"action":"insert","lines":["a"]}]}],[{"group":"doc","deltas":[{"start":{"row":1,"column":0},"end":{"row":2,"column":16},"action":"insert","lines":["open System","open System.Data"]}]}],[{"group":"doc","deltas":[{"start":{"row":2,"column":16},"end":{"row":3,"column":0},"action":"insert","lines":["",""]}]}],[{"group":"doc","deltas":[{"start":{"row":8,"column":1},"end":{"row":9,"column":0},"action":"insert","lines":["",""]}]}],[{"group":"doc","deltas":[{"start":{"row":9,"column":0},"end":{"row":10,"column":0},"action":"insert","lines":["",""]}]}],[{"group":"doc","deltas":[{"start":{"row":10,"column":0},"end":{"row":14,"column":1},"action":"insert","lines":["type ConnectionInfo = {","  ConnectionName:string","  ConnectionString:string","  ProviderName:string","}"]}]}],[{"group":"doc","deltas":[{"start":{"row":31,"column":4},"end":{"row":32,"column":0},"action":"insert","lines":["",""]},{"start":{"row":32,"column":0},"end":{"row":32,"column":4},"action":"insert","lines":["    "]}]}],[{"group":"doc","deltas":[{"start":{"row":32,"column":0},"end":{"row":43,"column":53},"action":"insert","lines":["type ConnectionInfoProvider = unit -> seq<ConnectionInfo>","","[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]","module Connection =","  open System","  open System.Data","","  let tryGetConnectionInfo (connectionInfos:seq<ConnectionInfo>) connectionName =","    let connectionInfoMap = ","      connectionInfos|> Seq.map (fun c->c.ConnectionName,c) |> Map.ofSeq","","    connectionInfoMap |> Map.tryFind connectionName  "]}]}]]},"ace":{"folds":[],"scrolltop":0,"scrollleft":0,"selection":{"start":{"row":43,"column":53},"end":{"row":43,"column":53},"isBackwards":true},"options":{"guessTabSize":true,"useWrapMode":false,"wrapToView":true},"firstLineState":0},"timestamp":1426886045006,"hash":"c252ad351ceabcc971ffe06d54a1d061800dc974"}
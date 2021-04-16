module fodinfo.Handlers.Status

open System
open Falco

let handleStatus : HttpHandler =
    fun ctx ->
        let route = Request.getRoute ctx
        let code = route.GetInt "code" 200

        Response.withStatusCode code
        >> Response.ofJson {| Status = code |}
        <| ctx

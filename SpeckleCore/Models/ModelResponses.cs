﻿extern alias SpeckleNewtonsoft;
using System;
using System.Collections.Generic;


namespace SpeckleCore
{
  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseBase
  {
    /// <summary>Besides the http status code, this tells you whether the call succeeded or not.</summary>
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "success", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public bool? Success { get; set; }

    /// <summary>Either an error or a confirmation.</summary>
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "message", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public string Message { get; set; }

    /// <summary>Returned resource (if querying by id)</summary>
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resource", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public object Resource { get; set; }

    /// <summary>Returned resources array (if it's a bulk query)</summary>
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resources", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<object> Resources { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseBase FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseBase>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseUser : ResponseBase
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resource", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public User Resource { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resources", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<User> Resources { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseUser FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseUser>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseClient : ResponseBase
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resource", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public AppClient Resource { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resources", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<AppClient> Resources { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseClient FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseClient>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseProject : ResponseBase
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resource", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public Project Resource { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resources", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<Project> Resources { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseProject FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseProject>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseComment : ResponseBase
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resource", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public Comment Resource { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resources", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<Comment> Resources { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseComment FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseComment>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseStream : ResponseBase
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resource", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public SpeckleStream Resource { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resources", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<SpeckleStream> Resources { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseStream FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseStream>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseObject : ResponseBase
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resource", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public SpeckleObject Resource { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resources", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<SpeckleObject> Resources { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseObject FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseObject>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseStreamClone : ResponseBase
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "clone", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public SpeckleStream Clone { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "parent", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public SpeckleStream Parent { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseStreamClone FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseStreamClone>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class ResponseStreamDiff : ResponseBase
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "objects", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public DiffObjectsResult Objects { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "layers", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public DiffLayersResult Layers { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static ResponseStreamDiff FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseStreamDiff>( data );
    }

  }

  /// <summary>The resource type you want to comment on.</summary>
  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public enum ResourceType
  {
    [System.Runtime.Serialization.EnumMember( Value = "stream" )]
    Stream = 0,

    [System.Runtime.Serialization.EnumMember( Value = "object" )]
    Object = 1,

    [System.Runtime.Serialization.EnumMember( Value = "project" )]
    Project = 2,

    [System.Runtime.Serialization.EnumMember( Value = "comment" )]
    Comment = 3,

  }

  /// <summary>it's a timestamp for each login.</summary>
  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class LoginDateProperty
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "date", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public string Date { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static LoginDateProperty FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<LoginDateProperty>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class Resource
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resourceType", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public string ResourceType { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "resourceId", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public string ResourceId { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static Resource FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<Resource>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class SpeckleBaseColor
  {
    /// <summary>alpha value</summary>
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "a", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public double? A { get; set; }

    /// <summary>hex color value</summary>
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "hex", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public string Hex { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static SpeckleBaseColor FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<SpeckleBaseColor>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class DiffObjectsResult
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "common", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<string> Common { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "inA", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<string> InA { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "inB", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<string> InB { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static DiffObjectsResult FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<DiffObjectsResult>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0)" )]
  [Serializable]
  public partial class DiffLayersResult
  {
    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "common", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<Layer> Common { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "inA", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<Layer> InA { get; set; }

    [SpeckleNewtonsoft.Newtonsoft.Json.JsonProperty( "inB", Required = SpeckleNewtonsoft.Newtonsoft.Json.Required.Default, NullValueHandling = SpeckleNewtonsoft.Newtonsoft.Json.NullValueHandling.Ignore )]
    public List<Layer> InB { get; set; }

    public string ToJson( )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.SerializeObject( this );
    }

    public static DiffLayersResult FromJson( string data )
    {
      return SpeckleNewtonsoft.Newtonsoft.Json.JsonConvert.DeserializeObject<DiffLayersResult>( data );
    }

  }

  [System.CodeDom.Compiler.GeneratedCode( "NSwag", "11.16.1.0 (NJsonSchema v9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0))" )]
  [Serializable]
  public partial class SpeckleException : System.Exception
  {
    public int StatusCode { get; private set; }

    public string Response { get; private set; }

    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

    public SpeckleException( string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException )
        : base( message, innerException )
    {
      StatusCode = statusCode;
      Response = response;
      Headers = headers;
    }

    public string ToString( )
    {
      return string.Format( "HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString() );
    }
  }

  [System.CodeDom.Compiler.GeneratedCode( "NSwag", "11.16.1.0 (NJsonSchema v9.10.41.0 (SpeckleNewtonsoft.Newtonsoft.Json v9.0.0.0))" )]
  [Serializable]
  public partial class SpeckleException<TResult> : SpeckleException
  {
    public TResult Result { get; private set; }

    public SpeckleException( string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException )
        : base( message, statusCode, response, headers, innerException )
    {
      Result = result;
    }
  }
}

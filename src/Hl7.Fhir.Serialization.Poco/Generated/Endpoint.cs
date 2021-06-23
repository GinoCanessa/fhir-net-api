// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Serialization.Poco
{
  /// <summary>
  /// JSON Serialization Extensions for Endpoint
  /// </summary>
  public static class EndpointSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Endpoint into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Endpoint current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Endpoint");
      // Complex: Endpoint, Export: Endpoint, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("connectionType", current.ConnectionType, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("name",current.NameElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("managingOrganization", current.ManagingOrganization, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("contact", current.Contact, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("period", current.Period, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("payloadType", current.PayloadType, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("payloadMimeType",current.PayloadMimeTypeElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("address",current.AddressElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("header",current.HeaderElement,writer,options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Endpoint
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Endpoint current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Endpoint >>> Endpoint.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Endpoint: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Endpoint
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Endpoint current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Endpoint error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"Endpoint error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Endpoint.EndpointStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "connectionType":
          current.ConnectionType = new Hl7.Fhir.Model.Coding();
          ((Hl7.Fhir.Model.Coding)current.ConnectionType).DeserializeJson(ref reader, options);
          break;

        case "name":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.NameElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.NameElement = new FhirString(reader.GetString());
          }
          break;

        case "_name":
          if (current.NameElement == null) { current.NameElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.NameElement).DeserializeJson(ref reader, options);
          break;

        case "managingOrganization":
          current.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.ManagingOrganization).DeserializeJson(ref reader, options);
          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Endpoint error reading 'contact' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Contact = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactPoint v_Contact = new Hl7.Fhir.Model.ContactPoint();
            v_Contact.DeserializeJson(ref reader, options);
            current.Contact.Add(v_Contact);

            if (!reader.Read())
            {
              throw new JsonException($"Endpoint error reading 'contact' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Contact.Count == 0)
          {
            current.Contact = null;
          }
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        case "payloadType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Endpoint error reading 'payloadType' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PayloadType = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_PayloadType = new Hl7.Fhir.Model.CodeableConcept();
            v_PayloadType.DeserializeJson(ref reader, options);
            current.PayloadType.Add(v_PayloadType);

            if (!reader.Read())
            {
              throw new JsonException($"Endpoint error reading 'payloadType' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PayloadType.Count == 0)
          {
            current.PayloadType = null;
          }
          break;

        case "payloadMimeType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Endpoint error reading 'payloadMimeType' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PayloadMimeTypeElement = new List<Code>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.PayloadMimeTypeElement.Add(new Code());
              reader.Skip();
            }
            else
            {
              current.PayloadMimeTypeElement.Add(new Code(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"Endpoint error reading 'payloadMimeType' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PayloadMimeTypeElement.Count == 0)
          {
            current.PayloadMimeTypeElement = null;
          }
          break;

        case "_payloadMimeType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Endpoint error reading 'payloadMimeType' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_payloadMimeType = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_payloadMimeType >= current.PayloadMimeTypeElement.Count)
            {
              current.PayloadMimeTypeElement.Add(new Code());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.PayloadMimeTypeElement[i_payloadMimeType++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"Endpoint error reading 'payloadMimeType' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "address":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AddressElement = new FhirUrl();
            reader.Skip();
          }
          else
          {
            current.AddressElement = new FhirUrl(reader.GetString());
          }
          break;

        case "_address":
          if (current.AddressElement == null) { current.AddressElement = new FhirUrl(); }
          ((Hl7.Fhir.Model.Element)current.AddressElement).DeserializeJson(ref reader, options);
          break;

        case "header":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Endpoint error reading 'header' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.HeaderElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.HeaderElement.Add(new FhirString());
              reader.Skip();
            }
            else
            {
              current.HeaderElement.Add(new FhirString(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"Endpoint error reading 'header' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.HeaderElement.Count == 0)
          {
            current.HeaderElement = null;
          }
          break;

        case "_header":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Endpoint error reading 'header' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_header = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_header >= current.HeaderElement.Count)
            {
              current.HeaderElement.Add(new FhirString());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.HeaderElement[i_header++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"Endpoint error reading 'header' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        // Complex: Endpoint, Export: Endpoint, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class EndpointJsonConverter : JsonConverter<Hl7.Fhir.Model.Endpoint>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Endpoint value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Endpoint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Endpoint();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
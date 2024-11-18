/*
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.Arrays;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.TypeAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;

import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

import org.openapitools.client.JSON;

/**
 * BananaReq
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", comments = "Generator version: 7.11.0-SNAPSHOT")
public class BananaReq {
  public static final String SERIALIZED_NAME_LENGTH_CM = "lengthCm";
  @SerializedName(SERIALIZED_NAME_LENGTH_CM)
  @javax.annotation.Nonnull
  private BigDecimal lengthCm;

  public static final String SERIALIZED_NAME_SWEET = "sweet";
  @SerializedName(SERIALIZED_NAME_SWEET)
  @javax.annotation.Nullable
  private Boolean sweet;

  public BananaReq() {
  }

  public BananaReq lengthCm(@javax.annotation.Nonnull BigDecimal lengthCm) {
    this.lengthCm = lengthCm;
    return this;
  }

  /**
   * Get lengthCm
   * @return lengthCm
   */
  @javax.annotation.Nonnull
  public BigDecimal getLengthCm() {
    return lengthCm;
  }

  public void setLengthCm(@javax.annotation.Nonnull BigDecimal lengthCm) {
    this.lengthCm = lengthCm;
  }


  public BananaReq sweet(@javax.annotation.Nullable Boolean sweet) {
    this.sweet = sweet;
    return this;
  }

  /**
   * Get sweet
   * @return sweet
   */
  @javax.annotation.Nullable
  public Boolean getSweet() {
    return sweet;
  }

  public void setSweet(@javax.annotation.Nullable Boolean sweet) {
    this.sweet = sweet;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BananaReq bananaReq = (BananaReq) o;
    return Objects.equals(this.lengthCm, bananaReq.lengthCm) &&
        Objects.equals(this.sweet, bananaReq.sweet);
  }

  @Override
  public int hashCode() {
    return Objects.hash(lengthCm, sweet);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BananaReq {\n");
    sb.append("    lengthCm: ").append(toIndentedString(lengthCm)).append("\n");
    sb.append("    sweet: ").append(toIndentedString(sweet)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("lengthCm");
    openapiFields.add("sweet");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("lengthCm");
  }

  /**
   * Validates the JSON Element and throws an exception if issues found
   *
   * @param jsonElement JSON Element
   * @throws IOException if the JSON Element is invalid with respect to BananaReq
   */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!BananaReq.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in BananaReq is not found in the empty JSON string", BananaReq.openapiRequiredFields.toString()));
        }
      }

      Set<Map.Entry<String, JsonElement>> entries = jsonElement.getAsJsonObject().entrySet();
      // check to see if the JSON string contains additional fields
      for (Map.Entry<String, JsonElement> entry : entries) {
        if (!BananaReq.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `BananaReq` properties. JSON: %s", entry.getKey(), jsonElement.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : BananaReq.openapiRequiredFields) {
        if (jsonElement.getAsJsonObject().get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!BananaReq.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'BananaReq' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<BananaReq> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(BananaReq.class));

       return (TypeAdapter<T>) new TypeAdapter<BananaReq>() {
           @Override
           public void write(JsonWriter out, BananaReq value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public BananaReq read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             return thisAdapter.fromJsonTree(jsonElement);
           }

       }.nullSafe();
    }
  }

  /**
   * Create an instance of BananaReq given an JSON string
   *
   * @param jsonString JSON string
   * @return An instance of BananaReq
   * @throws IOException if the JSON string is invalid with respect to BananaReq
   */
  public static BananaReq fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, BananaReq.class);
  }

  /**
   * Convert an instance of BananaReq to an JSON string
   *
   * @return JSON string
   */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


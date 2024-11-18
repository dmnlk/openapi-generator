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


package org.openapitools.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.v3.oas.annotations.media.Schema;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;
import jakarta.validation.constraints.*;
import jakarta.validation.Valid;

/**
 * Model for testing model name same as property name
 */
@Schema(description = "Model for testing model name same as property name")
@JsonPropertyOrder({
  Name.JSON_PROPERTY_NAME,
  Name.JSON_PROPERTY_SNAKE_CASE,
  Name.JSON_PROPERTY_PROPERTY,
  Name.JSON_PROPERTY_123NUMBER
})
@jakarta.annotation.Generated(value = "org.openapitools.codegen.languages.JavaJerseyServerCodegen", comments = "Generator version: 7.11.0-SNAPSHOT")
public class Name   {
  public static final String JSON_PROPERTY_NAME = "name";
  @JsonProperty(JSON_PROPERTY_NAME)
  private Integer name;

  public static final String JSON_PROPERTY_SNAKE_CASE = "snake_case";
  @JsonProperty(JSON_PROPERTY_SNAKE_CASE)
  private Integer snakeCase;

  public static final String JSON_PROPERTY_PROPERTY = "property";
  @JsonProperty(JSON_PROPERTY_PROPERTY)
  private String property;

  public static final String JSON_PROPERTY_123NUMBER = "123Number";
  @JsonProperty(JSON_PROPERTY_123NUMBER)
  private Integer _123number;

  public Name name(Integer name) {
    this.name = name;
    return this;
  }

  /**
   * Get name
   * @return name
   **/
  @JsonProperty(value = "name")
  @Schema(required = true, description = "")
  @NotNull 
  public Integer getName() {
    return name;
  }

  public void setName(Integer name) {
    this.name = name;
  }

  public Name snakeCase(Integer snakeCase) {
    this.snakeCase = snakeCase;
    return this;
  }

  /**
   * Get snakeCase
   * @return snakeCase
   **/
  @JsonProperty(value = "snake_case", access = JsonProperty.Access.READ_ONLY)
  @Schema(description = "")
  
  public Integer getSnakeCase() {
    return snakeCase;
  }

  public void setSnakeCase(Integer snakeCase) {
    this.snakeCase = snakeCase;
  }

  public Name property(String property) {
    this.property = property;
    return this;
  }

  /**
   * Get property
   * @return property
   **/
  @JsonProperty(value = "property")
  @Schema(description = "")
  
  public String getProperty() {
    return property;
  }

  public void setProperty(String property) {
    this.property = property;
  }

  public Name _123number(Integer _123number) {
    this._123number = _123number;
    return this;
  }

  /**
   * Get _123number
   * @return _123number
   **/
  @JsonProperty(value = "123Number", access = JsonProperty.Access.READ_ONLY)
  @Schema(description = "")
  
  public Integer get123number() {
    return _123number;
  }

  public void set123number(Integer _123number) {
    this._123number = _123number;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Name name = (Name) o;
    return Objects.equals(this.name, name.name) &&
        Objects.equals(this.snakeCase, name.snakeCase) &&
        Objects.equals(this.property, name.property) &&
        Objects.equals(this._123number, name._123number);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, snakeCase, property, _123number);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Name {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    snakeCase: ").append(toIndentedString(snakeCase)).append("\n");
    sb.append("    property: ").append(toIndentedString(property)).append("\n");
    sb.append("    _123number: ").append(toIndentedString(_123number)).append("\n");
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
}


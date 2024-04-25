/*
 * NewsCatcher-V3 Production API
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: 3.2.16
 * Contact: maksym@newscatcherapi.com
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.newscatcherapi.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

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
import org.apache.commons.lang3.StringUtils;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import com.konfigthis.newscatcherapi.client.JSON;

/**
 * Duplicates by original article ID request DTO
 */
@ApiModel(description = "Duplicates by original article ID request DTO")@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class DuplicatesByOriginalIdRequest {
  public static final String SERIALIZED_NAME_ORIGINAL_ARTICLE_ID = "original_article_id";
  @SerializedName(SERIALIZED_NAME_ORIGINAL_ARTICLE_ID)
  private String originalArticleId;

  public static final String SERIALIZED_NAME_PAGE = "page";
  @SerializedName(SERIALIZED_NAME_PAGE)
  private Integer page = 1;

  public static final String SERIALIZED_NAME_PAGE_SIZE = "page_size";
  @SerializedName(SERIALIZED_NAME_PAGE_SIZE)
  private Integer pageSize = 100;

  public DuplicatesByOriginalIdRequest() {
  }

  public DuplicatesByOriginalIdRequest originalArticleId(String originalArticleId) {
    
    
    
    
    this.originalArticleId = originalArticleId;
    return this;
  }

   /**
   * Get originalArticleId
   * @return originalArticleId
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public String getOriginalArticleId() {
    return originalArticleId;
  }


  public void setOriginalArticleId(String originalArticleId) {
    
    
    
    this.originalArticleId = originalArticleId;
  }


  public DuplicatesByOriginalIdRequest page(Integer page) {
    if (page != null && page < 0) {
      throw new IllegalArgumentException("Invalid value for page. Must be greater than or equal to 0.");
    }
    
    
    
    this.page = page;
    return this;
  }

   /**
   * Get page
   * minimum: 0
   * @return page
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "1", value = "")

  public Integer getPage() {
    return page;
  }


  public void setPage(Integer page) {
    if (page != null && page < 0) {
      throw new IllegalArgumentException("Invalid value for page. Must be greater than or equal to 0.");
    }
    
    
    this.page = page;
  }


  public DuplicatesByOriginalIdRequest pageSize(Integer pageSize) {
    if (pageSize != null && pageSize < 0) {
      throw new IllegalArgumentException("Invalid value for pageSize. Must be greater than or equal to 0.");
    }
    
    
    
    this.pageSize = pageSize;
    return this;
  }

   /**
   * Get pageSize
   * minimum: 0
   * @return pageSize
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "100", value = "")

  public Integer getPageSize() {
    return pageSize;
  }


  public void setPageSize(Integer pageSize) {
    if (pageSize != null && pageSize < 0) {
      throw new IllegalArgumentException("Invalid value for pageSize. Must be greater than or equal to 0.");
    }
    
    
    this.pageSize = pageSize;
  }

  /**
   * A container for additional, undeclared properties.
   * This is a holder for any undeclared properties as specified with
   * the 'additionalProperties' keyword in the OAS document.
   */
  private Map<String, Object> additionalProperties;

  /**
   * Set the additional (undeclared) property with the specified name and value.
   * If the property does not already exist, create it otherwise replace it.
   *
   * @param key name of the property
   * @param value value of the property
   * @return the DuplicatesByOriginalIdRequest instance itself
   */
  public DuplicatesByOriginalIdRequest putAdditionalProperty(String key, Object value) {
    if (this.additionalProperties == null) {
        this.additionalProperties = new HashMap<String, Object>();
    }
    this.additionalProperties.put(key, value);
    return this;
  }

  /**
   * Return the additional (undeclared) property.
   *
   * @return a map of objects
   */
  public Map<String, Object> getAdditionalProperties() {
    return additionalProperties;
  }

  /**
   * Return the additional (undeclared) property with the specified name.
   *
   * @param key name of the property
   * @return an object
   */
  public Object getAdditionalProperty(String key) {
    if (this.additionalProperties == null) {
        return null;
    }
    return this.additionalProperties.get(key);
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DuplicatesByOriginalIdRequest duplicatesByOriginalIdRequest = (DuplicatesByOriginalIdRequest) o;
    return Objects.equals(this.originalArticleId, duplicatesByOriginalIdRequest.originalArticleId) &&
        Objects.equals(this.page, duplicatesByOriginalIdRequest.page) &&
        Objects.equals(this.pageSize, duplicatesByOriginalIdRequest.pageSize)&&
        Objects.equals(this.additionalProperties, duplicatesByOriginalIdRequest.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(originalArticleId, page, pageSize, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DuplicatesByOriginalIdRequest {\n");
    sb.append("    originalArticleId: ").append(toIndentedString(originalArticleId)).append("\n");
    sb.append("    page: ").append(toIndentedString(page)).append("\n");
    sb.append("    pageSize: ").append(toIndentedString(pageSize)).append("\n");
    sb.append("    additionalProperties: ").append(toIndentedString(additionalProperties)).append("\n");
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
    openapiFields.add("original_article_id");
    openapiFields.add("page");
    openapiFields.add("page_size");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("original_article_id");
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to DuplicatesByOriginalIdRequest
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!DuplicatesByOriginalIdRequest.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in DuplicatesByOriginalIdRequest is not found in the empty JSON string", DuplicatesByOriginalIdRequest.openapiRequiredFields.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : DuplicatesByOriginalIdRequest.openapiRequiredFields) {
        if (jsonObj.get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonObj.toString()));
        }
      }
      if (!jsonObj.get("original_article_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `original_article_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("original_article_id").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!DuplicatesByOriginalIdRequest.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'DuplicatesByOriginalIdRequest' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<DuplicatesByOriginalIdRequest> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(DuplicatesByOriginalIdRequest.class));

       return (TypeAdapter<T>) new TypeAdapter<DuplicatesByOriginalIdRequest>() {
           @Override
           public void write(JsonWriter out, DuplicatesByOriginalIdRequest value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             obj.remove("additionalProperties");
             // serialize additonal properties
             if (value.getAdditionalProperties() != null) {
               for (Map.Entry<String, Object> entry : value.getAdditionalProperties().entrySet()) {
                 if (entry.getValue() instanceof String)
                   obj.addProperty(entry.getKey(), (String) entry.getValue());
                 else if (entry.getValue() instanceof Number)
                   obj.addProperty(entry.getKey(), (Number) entry.getValue());
                 else if (entry.getValue() instanceof Boolean)
                   obj.addProperty(entry.getKey(), (Boolean) entry.getValue());
                 else if (entry.getValue() instanceof Character)
                   obj.addProperty(entry.getKey(), (Character) entry.getValue());
                 else {
                   obj.add(entry.getKey(), gson.toJsonTree(entry.getValue()).getAsJsonObject());
                 }
               }
             }
             elementAdapter.write(out, obj);
           }

           @Override
           public DuplicatesByOriginalIdRequest read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             DuplicatesByOriginalIdRequest instance = thisAdapter.fromJsonTree(jsonObj);
             for (Map.Entry<String, JsonElement> entry : jsonObj.entrySet()) {
               if (!openapiFields.contains(entry.getKey())) {
                 if (entry.getValue().isJsonPrimitive()) { // primitive type
                   if (entry.getValue().getAsJsonPrimitive().isString())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsString());
                   else if (entry.getValue().getAsJsonPrimitive().isNumber())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsNumber());
                   else if (entry.getValue().getAsJsonPrimitive().isBoolean())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsBoolean());
                   else
                     throw new IllegalArgumentException(String.format("The field `%s` has unknown primitive type. Value: %s", entry.getKey(), entry.getValue().toString()));
                 } else if (entry.getValue().isJsonArray()) {
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), List.class));
                 } else { // JSON object
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), HashMap.class));
                 }
               }
             }
             return instance;
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of DuplicatesByOriginalIdRequest given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of DuplicatesByOriginalIdRequest
  * @throws IOException if the JSON string is invalid with respect to DuplicatesByOriginalIdRequest
  */
  public static DuplicatesByOriginalIdRequest fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, DuplicatesByOriginalIdRequest.class);
  }

 /**
  * Convert an instance of DuplicatesByOriginalIdRequest to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


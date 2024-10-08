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
import com.konfigthis.newscatcherapi.client.model.ArticlesPropertyInner;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

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
 * Search response data model
 */
@ApiModel(description = "Search response data model")@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class FSearchResponse {
  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private String status = "ok";

  public static final String SERIALIZED_NAME_TOTAL_HITS = "total_hits";
  @SerializedName(SERIALIZED_NAME_TOTAL_HITS)
  private Integer totalHits;

  public static final String SERIALIZED_NAME_PAGE = "page";
  @SerializedName(SERIALIZED_NAME_PAGE)
  private Integer page;

  public static final String SERIALIZED_NAME_TOTAL_PAGES = "total_pages";
  @SerializedName(SERIALIZED_NAME_TOTAL_PAGES)
  private Integer totalPages;

  public static final String SERIALIZED_NAME_PAGE_SIZE = "page_size";
  @SerializedName(SERIALIZED_NAME_PAGE_SIZE)
  private Integer pageSize;

  public static final String SERIALIZED_NAME_ARTICLES = "articles";
  @SerializedName(SERIALIZED_NAME_ARTICLES)
  private List<ArticlesPropertyInner> articles = null;

  public static final String SERIALIZED_NAME_USER_INPUT = "user_input";
  @SerializedName(SERIALIZED_NAME_USER_INPUT)
  private Object userInput;

  public FSearchResponse() {
  }

  public FSearchResponse status(String status) {
    
    
    
    
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "ok", value = "")

  public String getStatus() {
    return status;
  }


  public void setStatus(String status) {
    
    
    
    this.status = status;
  }


  public FSearchResponse totalHits(Integer totalHits) {
    
    
    
    
    this.totalHits = totalHits;
    return this;
  }

   /**
   * Get totalHits
   * @return totalHits
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getTotalHits() {
    return totalHits;
  }


  public void setTotalHits(Integer totalHits) {
    
    
    
    this.totalHits = totalHits;
  }


  public FSearchResponse page(Integer page) {
    
    
    
    
    this.page = page;
    return this;
  }

   /**
   * Get page
   * @return page
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getPage() {
    return page;
  }


  public void setPage(Integer page) {
    
    
    
    this.page = page;
  }


  public FSearchResponse totalPages(Integer totalPages) {
    
    
    
    
    this.totalPages = totalPages;
    return this;
  }

   /**
   * Get totalPages
   * @return totalPages
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getTotalPages() {
    return totalPages;
  }


  public void setTotalPages(Integer totalPages) {
    
    
    
    this.totalPages = totalPages;
  }


  public FSearchResponse pageSize(Integer pageSize) {
    
    
    
    
    this.pageSize = pageSize;
    return this;
  }

   /**
   * Get pageSize
   * @return pageSize
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Integer getPageSize() {
    return pageSize;
  }


  public void setPageSize(Integer pageSize) {
    
    
    
    this.pageSize = pageSize;
  }


  public FSearchResponse articles(List<ArticlesPropertyInner> articles) {
    
    
    
    
    this.articles = articles;
    return this;
  }

  public FSearchResponse addArticlesItem(ArticlesPropertyInner articlesItem) {
    if (this.articles == null) {
      this.articles = new ArrayList<>();
    }
    this.articles.add(articlesItem);
    return this;
  }

   /**
   * Get articles
   * @return articles
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<ArticlesPropertyInner> getArticles() {
    return articles;
  }


  public void setArticles(List<ArticlesPropertyInner> articles) {
    
    
    
    this.articles = articles;
  }


  public FSearchResponse userInput(Object userInput) {
    
    
    
    
    this.userInput = userInput;
    return this;
  }

   /**
   * Get userInput
   * @return userInput
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public Object getUserInput() {
    return userInput;
  }


  public void setUserInput(Object userInput) {
    
    
    
    this.userInput = userInput;
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
   * @return the FSearchResponse instance itself
   */
  public FSearchResponse putAdditionalProperty(String key, Object value) {
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
    FSearchResponse fsearchResponse = (FSearchResponse) o;
    return Objects.equals(this.status, fsearchResponse.status) &&
        Objects.equals(this.totalHits, fsearchResponse.totalHits) &&
        Objects.equals(this.page, fsearchResponse.page) &&
        Objects.equals(this.totalPages, fsearchResponse.totalPages) &&
        Objects.equals(this.pageSize, fsearchResponse.pageSize) &&
        Objects.equals(this.articles, fsearchResponse.articles) &&
        Objects.equals(this.userInput, fsearchResponse.userInput)&&
        Objects.equals(this.additionalProperties, fsearchResponse.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(status, totalHits, page, totalPages, pageSize, articles, userInput, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FSearchResponse {\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    totalHits: ").append(toIndentedString(totalHits)).append("\n");
    sb.append("    page: ").append(toIndentedString(page)).append("\n");
    sb.append("    totalPages: ").append(toIndentedString(totalPages)).append("\n");
    sb.append("    pageSize: ").append(toIndentedString(pageSize)).append("\n");
    sb.append("    articles: ").append(toIndentedString(articles)).append("\n");
    sb.append("    userInput: ").append(toIndentedString(userInput)).append("\n");
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
    openapiFields.add("status");
    openapiFields.add("total_hits");
    openapiFields.add("page");
    openapiFields.add("total_pages");
    openapiFields.add("page_size");
    openapiFields.add("articles");
    openapiFields.add("user_input");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("user_input");
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to FSearchResponse
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!FSearchResponse.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in FSearchResponse is not found in the empty JSON string", FSearchResponse.openapiRequiredFields.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : FSearchResponse.openapiRequiredFields) {
        if (jsonObj.get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonObj.toString()));
        }
      }
      if ((jsonObj.get("status") != null && !jsonObj.get("status").isJsonNull()) && !jsonObj.get("status").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `status` to be a primitive type in the JSON string but got `%s`", jsonObj.get("status").toString()));
      }
      if (jsonObj.get("articles") != null && !jsonObj.get("articles").isJsonNull()) {
        JsonArray jsonArrayarticles = jsonObj.getAsJsonArray("articles");
        if (jsonArrayarticles != null) {
          // ensure the json data is an array
          if (!jsonObj.get("articles").isJsonArray()) {
            throw new IllegalArgumentException(String.format("Expected the field `articles` to be an array in the JSON string but got `%s`", jsonObj.get("articles").toString()));
          }

          // validate the optional field `articles` (array)
          for (int i = 0; i < jsonArrayarticles.size(); i++) {
            ArticlesPropertyInner.validateJsonObject(jsonArrayarticles.get(i).getAsJsonObject());
          };
        }
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!FSearchResponse.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'FSearchResponse' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<FSearchResponse> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(FSearchResponse.class));

       return (TypeAdapter<T>) new TypeAdapter<FSearchResponse>() {
           @Override
           public void write(JsonWriter out, FSearchResponse value) throws IOException {
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
                 else if (entry.getValue() == null) {
                   obj.addProperty(entry.getKey(), (String) null);
                 } else {
                   obj.add(entry.getKey(), gson.toJsonTree(entry.getValue()).getAsJsonObject());
                 }
               }
             }
             elementAdapter.write(out, obj);
           }

           @Override
           public FSearchResponse read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             FSearchResponse instance = thisAdapter.fromJsonTree(jsonObj);
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
  * Create an instance of FSearchResponse given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of FSearchResponse
  * @throws IOException if the JSON string is invalid with respect to FSearchResponse
  */
  public static FSearchResponse fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, FSearchResponse.class);
  }

 /**
  * Convert an instance of FSearchResponse to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}


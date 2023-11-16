package com.konfigthis.newscatcherapi.client;

import static org.junit.Assert.assertNotNull;

import org.junit.Test;

public class SimpleTest {
    final String MOCK_SERVER_URL = "http://localhost:4010";

    @Test
    public void initClientTest() {
        Configuration configuration = new Configuration();
        configuration.apiKey = "API_KEY";
        Newscatcher client = new Newscatcher(configuration);
        assertNotNull(client);
    }
}

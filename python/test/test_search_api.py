"""
    NewsCatcher News API V2

    NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python)   # noqa: E501

    The version of the OpenAPI document: 1.0.1
    Contact: team@newscatcherapi.com
    Generated by: https://konfigthis.com
"""


import unittest

import os
from newscatcherapi_client import Newscatcher


class TestSearchApi(unittest.TestCase):
    """SearchApi unit test stubs"""

    def setUp(self):
        self.newscatcher = Newscatcher(api_key=os.environ["NEWSCATCHER_API_KEY"])

    def tearDown(self):
        pass

    def test_get(self):
        """Test case for get

        Search for specific news articles  # noqa: E501
        """
        response = self.newscatcher.search.get(query_params={"q": "Apple", "from": "three months ago"})
        assert response is not None, "Received null response"

    def test_post(self):
        """Test case for post

        Search for specific news articles  # noqa: E501
        """
        response = self.newscatcher.search.post(body={"q": 'Apple', "from": 'three months ago'})
        assert response is not None, "Received null response"


if __name__ == '__main__':
    unittest.main()

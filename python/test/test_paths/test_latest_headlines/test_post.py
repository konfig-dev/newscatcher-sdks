# coding: utf-8

"""


    Generated by: https://konfigthis.com
"""

import unittest
from unittest.mock import patch

import urllib3

import newscatcherapi_client
from newscatcherapi_client.paths.latest_headlines import post  # noqa: E501
from newscatcherapi_client import configuration, schemas, api_client

from .. import ApiTestMixin


class TestLatestHeadlines(ApiTestMixin, unittest.TestCase):
    """
    LatestHeadlines unit test stubs
        Get Latest News Articles  # noqa: E501
    """
    _configuration = configuration.Configuration()

    def setUp(self):
        used_api_client = api_client.ApiClient(configuration=self._configuration)
        self.api = post.ApiForpost(api_client=used_api_client)  # noqa: E501

    def tearDown(self):
        pass

    response_status = 200




if __name__ == '__main__':
    unittest.main()

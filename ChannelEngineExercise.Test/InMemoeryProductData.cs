using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineExercise.Test
{
    public class InMemoeryProductData
    {
       public string GetDummyTestData()
        {
            return @"
                              {
                                  'Content': [
                                    {
                                      'Id': 17,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029189',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 3,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 16,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029179',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 8,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 15,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029139',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 4,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 14,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029129',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 5,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 13,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029111',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 9,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 13,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029111',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 5,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 12,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029111',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 1,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 11,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029109',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 1,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 10,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-32480',
                                      'MerchantOrderNo': 'GetInProgressData5',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:15.6833333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029609',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 2,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10193',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 9,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-60455',
                                      'MerchantOrderNo': 'GetInProgressData4',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:17:05.99+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029609',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: M',
                                          'StockLocation': {
                                            'Id': 2,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10717',
                                          'MerchantProductNo': '001201-M',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 8,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-83314',
                                      'MerchantOrderNo': 'GetInProgressData3',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:16:58.48+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029609',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: XL',
                                          'StockLocation': {
                                            'Id': 2,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10267',
                                          'MerchantProductNo': '001201-XL',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 7,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-18325',
                                      'MerchantOrderNo': 'GetInProgressData2',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:16:50.4333333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029609',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 2,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10134',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 1
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 6,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-70348',
                                      'MerchantOrderNo': 'Test',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:16:43.8133333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029609',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: M',
                                          'StockLocation': {
                                            'Id': 2,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10527',
                                          'MerchantProductNo': '001201-M',
                                          'Quantity': 3
                                        }
                                      ]
                                    },
                                    {
                                      'Id': 5,
                                      'ChannelName': 'Test channel',
                                      'ChannelId': 1,
                                      'GlobalChannelName': 'Custom Channel',
                                      'GlobalChannelId': 55,
                                      'ChannelOrderNo': 'CE-TEST-65608',
                                      'MerchantOrderNo': 'GreatId',
                                      'Status': 'IN_PROGRESS',
                                      'CreatedAt': '2020-06-15T11:16:34.8933333+02:00',
                                      'Lines': [
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029609',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: S',
                                          'StockLocation': {
                                            'Id': 2,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10924',
                                          'MerchantProductNo': '001201-S',
                                          'Quantity': 2
                                        },
                                        {
                                          'Status': 'IN_PROGRESS',
                                          'Gtin': '8719351029609',
                                          'Description': 'T-shirt met lange mouw BASIC petrol: L',
                                          'StockLocation': {
                                            'Id': 2,
                                            'Name': 'api-dev'
                                          },
                                          'ChannelProductNo': '10374',
                                          'MerchantProductNo': '001201-L',
                                          'Quantity': 1
                                        }
                                      ]
                                    }
                                  ],
                                  'Count': 14,
                                  'TotalCount': 14,
                                  'ItemsPerPage': 100,
                                  'StatusCode': 200,
                                  'LogId': null,
                                  'Success': true,
                                  'Message': null,
                                  'ValidationErrors': {}
                                }
                          ";
        }
    }
}

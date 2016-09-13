/* 
 * LIO - Order Management API
 *
 * API de gerenciamento de pedidos da LIO.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing OrderManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderManagementApiTests
    {
        private OrderManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderManagementApi
            //Assert.IsInstanceOfType(typeof(OrderManagementApi), instance, "instance is a OrderManagementApi");
        }

        
        /// <summary>
        /// Test OrderAddItem
        /// </summary>
        [Test]
        public void OrderAddItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string id = null;
            //OrderItem body = null;
            //var response = instance.OrderAddItem(clientId, accessToken, merchantId, id, body);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test OrderCreate
        /// </summary>
        [Test]
        public void OrderCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //Order body = null;
            //var response = instance.OrderCreate(clientId, accessToken, merchantId, body);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test OrderDelete
        /// </summary>
        [Test]
        public void OrderDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string id = null;
            //instance.OrderDelete(clientId, accessToken, merchantId, id);
            
        }
        
        /// <summary>
        /// Test OrderDeleteItem
        /// </summary>
        [Test]
        public void OrderDeleteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string id = null;
            //string itemId = null;
            //var response = instance.OrderDeleteItem(clientId, accessToken, merchantId, id, itemId);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
        /// <summary>
        /// Test OrderGet
        /// </summary>
        [Test]
        public void OrderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string id = null;
            //var response = instance.OrderGet(clientId, accessToken, merchantId, id);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test OrderGetByParameters
        /// </summary>
        [Test]
        public void OrderGetByParametersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string parameters = null;
            //instance.OrderGetByParameters(clientId, accessToken, merchantId, parameters);
            
        }
        
        /// <summary>
        /// Test OrderGetItem
        /// </summary>
        [Test]
        public void OrderGetItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string id = null;
            //var response = instance.OrderGetItem(clientId, accessToken, merchantId, id);
            //Assert.IsInstanceOf<OrderItem> (response, "response is OrderItem");
        }
        
        /// <summary>
        /// Test OrderGetTransactions
        /// </summary>
        [Test]
        public void OrderGetTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string id = null;
            //var response = instance.OrderGetTransactions(clientId, accessToken, merchantId, id);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test OrderUpdate
        /// </summary>
        [Test]
        public void OrderUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string id = null;
            //string operation = null;
            //instance.OrderUpdate(clientId, accessToken, merchantId, id, operation);
            
        }
        
        /// <summary>
        /// Test OrderUpdateItem
        /// </summary>
        [Test]
        public void OrderUpdateItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string merchantId = null;
            //string id = null;
            //string itemId = null;
            //OrderItem body = null;
            //var response = instance.OrderUpdateItem(clientId, accessToken, merchantId, id, itemId, body);
            //Assert.IsInstanceOf<Response> (response, "response is Response");
        }
        
    }

}

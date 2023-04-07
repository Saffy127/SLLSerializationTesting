using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test_Assignment_3
{
    public class LinkedListTests
    {
        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            // Create your concrete linked list class and assign to to linkedList.
            this.linkedList = new SLL();
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty()
        {
            Assert.True(this.linkedList.IsEmpty());
            Assert.Equals(0, this.linkedList.Size());
        }

        //Tests appending elements to the linked list.
        [Test]
        public void TestAppendNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.Equals(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.Equals("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.Equals("b", this.linkedList.Retrieve(1));

            // Test the third node value is c
            Assert.Equals("c", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.Equals("d", this.linkedList.Retrieve(3));
        }

        //Tests prepending nodes to linked list.
        [Test]
        public void testPrependNodes()
        {
            this.linkedList.Prepend("a");
            this.linkedList.Prepend("b");
            this.linkedList.Prepend("c");
            this.linkedList.Prepend("d");

            /**
             * Linked list should now be:
             * 
             * d -> c -> b -> a
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.Equals(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.Equals("d", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.Equals("c", this.linkedList.Retrieve(1));

            // Test the third node value is c
            Assert.Equals("b", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.Equals("a", this.linkedList.Retrieve(3));
        }

        //Tests inserting node at valid index.
        [Test]
        public void TestInsertNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Insert("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.Equals(5, this.linkedList.Size());

            // Test the first node value is a
            Assert.Equals("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.Equals("b", this.linkedList.Retrieve(1));

            // Test the third node value is e
            Assert.Equals("e", this.linkedList.Retrieve(2));

            // Test the third node value is c
            Assert.Equals("c", this.linkedList.Retrieve(3));

            // Test the fourth node value is d
            Assert.Equals("d", this.linkedList.Retrieve(4));
        }

        //Tests replacing existing nodes data.
        [Test]
        public void TestReplaceNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Replace("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.Equals(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.Equals("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.Equals("b", this.linkedList.Retrieve(1));

            // Test the third node value is e
            Assert.Equals("e", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.Equals("d", this.linkedList.Retrieve(3));
        }

        //Tests deleting node from linked list.
        [Test]
        public void TestDeleteNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Delete(2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.Equals(3, this.linkedList.Size());

            // Test the first node value is a
            Assert.Equals("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.Equals("b", this.linkedList.Retrieve(1));

            // Test the fourth node value is d
            Assert.Equals("d", this.linkedList.Retrieve(2));
        }

        //Tests finding and retrieving node in linked list.
        [Test]
        public void TestFindNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            bool contains = this.linkedList.Contains("b");
            Assert.True(contains);

            int index = this.linkedList.IndexOf("b");
            Assert.Equals(1, index);

            string value = (string)this.linkedList.Retrieve(1);
            Assert.Equals("b", value);
        }
        // Test case to check inserting a node at the beginning of the linked list
        [Test]
        public void TestInsertNodeAtBeginning()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");

            this.linkedList.Insert("c", 0);

            Assert.AreEqual(3, this.linkedList.Size());
            Assert.AreEqual("c", this.linkedList.Retrieve(0));
            Assert.AreEqual("a", this.linkedList.Retrieve(1));
            Assert.AreEqual("b", this.linkedList.Retrieve(2));
        }
        // Test case to check inserting a node at the end of the linked list
        [Test]
        public void TestInsertNodeAtEnd()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");

            this.linkedList.Insert("c", 2);

            Assert.AreEqual(3, this.linkedList.Size());
            Assert.AreEqual("a", this.linkedList.Retrieve(0));
            Assert.AreEqual("b", this.linkedList.Retrieve(1));
            Assert.AreEqual("c", this.linkedList.Retrieve(2));
        }
        //Test case to check deleting the first node of the linked list
        [Test]
        public void TestDeleteFirstNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");

            this.linkedList.Delete(0);

            Assert.AreEqual(2, this.linkedList.Size());
            Assert.AreEqual("b", this.linkedList.Retrieve(0));
            Assert.AreEqual("c", this.linkedList.Retrieve(1));
        }
        
        [Test]
        public void TestDeleteLastNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");

            this.linkedList.Delete(2);

            Assert.AreEqual(2, this.linkedList.Size());
            Assert.AreEqual("a", this.linkedList.Retrieve(0));
            Assert.AreEqual("b", this.linkedList.Retrieve(1));
        }
        // Test case to check if the linked list contains a specific node
        [Test]
        public void TestAppendContainsNodes()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");

            Assert.IsTrue(this.linkedList.Contains("a"));
            Assert.IsTrue(this.linkedList.Contains("b"));
            Assert.IsTrue(this.linkedList.Contains("c"));
            Assert.IsFalse(this.linkedList.Contains("d"));
        }
        // Test case to check clearing the linked list
        [Test]
        public void TestClearList()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");

            this.linkedList.Clear();

            Assert.IsTrue(this.linkedList.IsEmpty());
            Assert.AreEqual(0, this.linkedList.Size());
        }
    }
    
}

1. What database models do you know?
  - Flat Data Model
      Flat data model is the first and foremost introduced model and in this all the data used is kept in the same plane.
      Since it was used earlier this model was not so scientific.
  
  - Entity Relationship Data Model
      Entity relationship model is based on the notion of the real world entities and their relationships. While formulating the real           world scenario in to the database model an entity set is created and this model is dependent on two vital things and they are : 

      - Entity and their attributes
      - Relationships among entities
      
      An entity has a real world property called attribute and attribute define by a set of values called domain. For example, in a   
      university a student is an entity, university is the database, name and age and sex are the attributes. The relationships among  
      entities define the logical association between entities.
  
  - Relational Data Model
      Relational model is the most popular model and the most extensively used model. In this model the data can be stored in the tables 
      and this storing is called as relation, the relations can be normalized and the normalized relation values are called atomic
      values. Each row in a relation contains unique value and it is called as tuple, each column contains value from same domain and it
      is called as attribute.
      
  - Network Data Model
      Network model has the entities which are organized in a graphical representation and some entities in the graph can be accessed
      through several paths.
      
  - Hierarchical Data Model
      Hierarchical model has one parent entity with several children entity but at the top we should have only one entity called root.
      For example, department is the parent entity called root and it has several children entities like students, professors and many
      more.
      
  - Object oriented Data Model
      Object oriented data model is one of the developed data model and this can hold the audio, video and graphic files. These consist
      of data piece and the methods which are the DBMS instructions.
  
  - Record base Data Model
      Record base model is used to specify the overall structure of the database and in this there are many record types. Each record
      type has fixed no. of fields having the fixed length.
  
  - Object relation Data Model
      Object relation model is a very powerful model but coming to it’s design it is quiet complex. This complexity is not problem
      because it gives efficient results and widespread with huge applications. It has a feature which allows working with other models
      like working with the very known relation model.

  - Semi structured Data Model
      Semi structured data model is a self describing data model, in this the information that is normally associated with a scheme is
      contained within the data and this property is called as the self describing property.

  - Associative Data Model
      Associative model has a division property, this divides the real world things about which data is to be recorded in two sorts i.e.
      between entities and associations. Thus, this model does the division for dividing the real world data to the entities and
      associations.

  - Context Data Model
      Context data model is a flexible model because it is a collection of many data models. It is a collection of the data models like
      object oriented data model, network model, semi structured model. So, in this different types of works can be done due to the
      versatility of it. Therefore, this support different types of users and differ by the interaction of users in database and also
      the data models in DBMS brought a revolutionary change in industries by the handling of relevant data. The data models in DBMS are
      the systems that help to use and create databases, as we have seen there are different types of data models and depending on the
      kind of structure needed we can select the data model in DBMS.
      
      
2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
  - SQL Commands
    - DDL
      - CREATE
      - ALTER
      - DROP
      - RENAME
      - TRUNCATE
      - COMMENT
    - DML
      - SELECT
      - INSERT
      - UPDATE
      - DELETE
      - MERGE
      - CALL
      - EXPLAIN PLAN
      - LOCK TABLE
    - DCL
      - GRANT
      - REVOKE
    - TCL
      - COMMIT
      - ROLLBACK
      - SAVEPOINT
      - SET TRANSACTION
      
3. Define what is "table" in database terms.
  - In relational databases, and flat file databases, a table is a set of data elements (values) using a model of vertical columns
    (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect. A table has a specified
    number of columns, but can have any number of rows.

4. Explain the difference between a primary and a foreign key.
  - Difference between Primary Key and Foreign Key. Primary key uniquely identify a record in the table. Foreign key is a field in the       table that is primary key in another table. By default, Primary key is clustered index and data in the database table is physically     organized in the sequence of clustered index.
  
5. Explain the different kinds of relationships between tables in relational databases.
  - One-to-One
      A row in table A can have only one matching row in table B, and vice versa. This is not a common relationship type, as the data
      stored in table B could just have easily been stored in table A. However, there are some valid reasons for using this relationship
      type. A one-to-one relationship  can be used for security purposes, to divide a large table, and various other specific purposes.
  - One-to-Many (or Many-to-One)     
      This is the most common relationship type. In this type of relationship, a row in table A can have many matching rows in table B,
      but a row in table B can have only one matching row in table A.
  - Many-to-Many
      In a many-to-many relationship, a row in table A can have many matching rows in table B, and vice versa. A many-to-many
      relationship could be thought of as two one-to-many relationships, linked by an intermediary table. The intermediary table is
      typically referred to as a “junction table” (also as a “cross-reference table”). This table is used to link the other two tables
      together. It does this by having two fields that reference the primary key of each of the other two tables.

6. When is a certain database schema normalized?
  - Database normalization is the process of structuring a relational database in accordance with a series of so-called normal forms in
  order to reduce data redundancy and improve data integrity.
  
7. What are the advantages of normalized databases?
  - Reduces Data Duplication
  - Groups Data Logically
  - Enforces Referential Integrity on Data
  
8. What are database integrity constraints and when are they used?
  - Referential integrity is the enforcement of relationships between data in joined tables. Without referential integrity, data in a
    table can lose its link to other tables where related data is held. This leads to orphaned and inconsistent data in tables. A  
    normalized database, with joins between tables, can prevent this from happening.

9. Point out the pros and cons of using indexes in a database.
  - While it (mostly) speeds up a select, it slows down inserts, updates and deletes because the database engine does not have to write
    the data only, but the index, too. An index need space on hard disk (and much more important) in RAM. An index that can not be held
    in RAM is pretty useless. An index on a column with only a few different values doesn't speed up selects, because it can not sort
    out much rows (for example a column "gender", which usually has only two different values - male, female).

10. What's the main purpose of the SQL language?
  - SQL is used to communicate with a database. According to ANSI (American National Standards Institute), it is the standard language
    for relational database management systems. SQL statements are used to perform tasks such as update data on a database, or retrieve
    data from a database.
  
11. What are transactions used for?
  - Introduction to Transactions. A transaction is a logical unit of work that contains one or more SQL statements. A transaction is an
    atomic unit. The effects of all the SQL statements in a transaction can be either all committed (applied to the database) or all
    rolled back (undone from the database).
    
12. What is a NoSQL database?
  - A NoSQL (originally referring to "non SQL" or "non relational") database provides a mechanism for storage and retrieval of data that
    is modeled in means other than the tabular relations used in relational databases. NoSQL databases are increasingly used in big
    data and real-time web applications.
    Example: 1. Document model - MongoDB, CouchDB
             2. Key-value model - Redis

13. Explain the classical non-relational data models.
    - A key-value MODEL/Database, also called a key-value store, is the most flexible type of NoSQL database. Key-value databases have
      emerged as an alternative to many of the limitations of traditional relational databases, where data is structured in tables and
      the schema must be predefined.
    - A document-oriented database, or document store, is a computer program designed for storing, retrieving and managing document -
      oriented information, also known as semi-structured data. Document-oriented databases are inherently a subclass of the key -
      value store, another NoSQL database concept.
    - A wide column store is a type of NoSQL database. It uses tables, rows, and columns, but unlike a relational database, the names
      and format of the columns can vary from row to row in the same table. ... Wide column stores that support column families are also
      known as column family databases.

14. Give few examples of NoSQL databases and their pros and cons.
    - Pros:
            1. Flexible Scalability - 
            2. Stores Massive Amounts Of Data
            3. Database Maintenance
            4. Economical
    - Cons:  
            1. Not Mature 
            2. Less Support
            3. Business Analytics And Intelligence
   

use CustomerView
ALTER TABLE [dbo].[Customers]
   ADD CONSTRAINT FK_CustomerStatusId FOREIGN KEY (StatusID)
      REFERENCES [dbo].[Statuses](StatusID)
      ON DELETE CASCADE
      ON UPDATE CASCADE

ALTER TABLE [dbo].[Customers]
   ADD CONSTRAINT FK_CustomerTitleId FOREIGN KEY (TitleID)
      REFERENCES [dbo].[Titles](TitleID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
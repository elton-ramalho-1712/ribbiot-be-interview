Create table Audit 
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    created_by NVARCHAR(100) NOT NULL,
    target_url NVARCHAR(250) NOT NULL, --job or document URL
    target_user NVARCHAR(100) NOT NULL,
    created_at DATETIME DEFAULT GETDATE()
    notified_at DATETIME DEFAULT NULL
);
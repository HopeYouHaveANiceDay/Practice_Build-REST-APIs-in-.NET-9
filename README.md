References:

Step 1: How to use Visual Studio Code instead of Visual Studio (e.g., by installing C# and the C# Dev Kit in Visual Studio Code) : https://youtu.be/ZVGutgqBMUM?si=POZ_w76qPnEkbgvI 

Step 2: Build a REST API in .NET 9: https://youtu.be/38GNKtclDdE?si=W3_1ozdNTZeXFWo4 


🧰 My Development Stack

      •	Code Editor: Visual Studio Code (VS Code)
      
      •	Database: SQL Server running inside a Docker container
      
      •	Database Management Tool: Azure Data Studio
      
      •	Operating System: macOS


🔄 Differences from the Tutorial

  The original tutorial used:
  
      •	Visual Studio (Windows)
      
      •	SQL Server 2022 Express Edition
      
      •	SQL Server Management Studio (SSMS)


  In contrast, I used:
    
      •	VS Code instead of Visual Studio
      
      •	SQL Server in Docker instead of Microsoft SQL Server 2022 Express
      
      •	Azure Data Studio instead of SQL Server Management Studio (SSMS)


📁 What I’ve Completed

      •	Built a REST API with CRUD functionality
      
      •	Connected the API to SQL Server via Docker
      
      •	Verified that all database changes made through the API are reflected in Azure Data Studio
      
      •	Successfully ran and tested the project on macOS
      
      •	A screenshot was captured showing the output of Azure Data Studio running on macOS


🐳 為什麼使用 Docker 運行 SQL Server？

(1) 快速部署與隔離環境
      Docker 可以在幾秒鐘內啟動 SQL Server，無需安裝繁瑣的軟體。
      每個容器都是獨立的，不會影響你的主機系統或其他專案。
  
(2) 跨平台一致性
      不管你是在 Windows、macOS 還是 Linux 上開發，Docker 都能提供一致的 SQL Server 環境。
      減少「在我電腦上可以運行」的問題。
  
(3) 便於版本控制與測試
      你可以指定 SQL Server 的版本，例如 2022-latest，確保與生產環境一致。
      可以快速切換不同版本進行測試。
  
(4) 適合 CI/CD 和團隊協作
      在 DevOps 流程中，Docker 容器可以自動啟動並初始化資料庫，方便自動化測試。
      團隊成員只需拉取 Docker 映像即可開始開發，無需手動安裝 SQL Server。

🧰 Azure Data Studio 是做什麼的？
      Azure Data Studio 是一個 資料庫管理工具，主要用途是：
          (1) 連接 SQL Server（不管是本機、Docker 或雲端）
          (2) 編寫與執行 SQL 查詢
          (3) 管理資料表、檢視、儲存過程等
          (4) 視覺化資料與效能分析
      👉 它不能獨立運行 SQL Server，而是需要連接到一個已啟動的 SQL Server 實例。

✅ 結論
  => Docker 是用來「啟動並運行」SQL Server 的環境。
  => Azure Data Studio 是用來「連接並管理」SQL Server 的工具。
兩者是互補的：Docker 提供資料庫，Azure Data Studio 提供操作介面。

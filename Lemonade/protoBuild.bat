for %%i in (./proto/*.proto) do protoc --csharp_out ./Net/Protocol --proto_path ./proto %%i
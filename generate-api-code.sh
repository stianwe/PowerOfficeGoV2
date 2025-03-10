#!/bin/bash
mkdir -p specs
cd specs

wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/accountingsettings.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/accounttransactions.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/clientadmin.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/clientbankaccounts.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/clientIntegrationInformation.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/contactbankaccounts.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/contactdeliveryaddresses.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/contactgroups.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/contactpersons.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/customdimensions.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/customerledger.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/customers.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/departments.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/employees.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/enterprises.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/incomingInvoices.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/journalentryvouchers.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/locations.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/onboarding.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/organizationsettings.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/outgoingInvoices.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/payroll.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/products.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/projects.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/quality.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/salarylines.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/salesOrders.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/salessettings.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/supplierledger.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/suppliers.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/trialbalance.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/voucherapproval.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/voucherdocumentation.json
wget https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/openapispecs/voucherposting.json

cd ..
openapi-generator generate --generator-name csharp --input-spec-root-directory specs --artifact-id PowerOfficeGoV2 --package-name PowerOfficeGoV2
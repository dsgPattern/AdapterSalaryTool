namespace SalaryManagementTool
{
    class SalaryToolFactory
    {
        /// <summary>
        /// Dummy factory, just to show that the Client(main method) doesn't know anything about a specific salary processor, but uses the ISalaryProcessor abstraction
        /// </summary>
        /// <returns></returns>
        public static ISalaryProcessor GiveMeSalaryProcessor(bool useNewTool)
        {
            if (useNewTool)
            {
                return new SalaryUploadManagerAdapter();
            }

            return new BankUploadManager();
        }
    }
}

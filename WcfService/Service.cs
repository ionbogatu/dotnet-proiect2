using API;
using Model;
using System;
using System.Collections.Generic;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in both code and config file together.
    public class Service : IService
    {
        private ResourceRepository resourceRepository;

        public Service()
        {
            resourceRepository = new ResourceRepository();
        }

        public List<Model.resource> getActiveResources()
        {
            var result = new List<resource>();

            try
            {
                result = resourceRepository.getActiveResources();
            } catch (Exception)
            {
                // intentionally ignored exception
            }

            return result;
        }

        public string GetMessage()
        {
            return "Hello World";
        }

        public void deleteResource(int id)
        {
            resourceRepository.deleteResource(id);
        }

        public void saveResources(List<SelectedEntity> resources)
        {
            resourceRepository.saveResources(resources);
        }
    }
}

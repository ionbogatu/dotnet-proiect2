using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GUI
{
    partial class MyPhotos
    {
        private void findButton_Click(object sender, EventArgs e)
        {
            selectedEntities = new List<Dictionary<string, object>>();

            IQueryable<resource> resourceQuery = client.getActiveResources().AsQueryable();

            IQueryable<resource> tmpResourceQuery;
            if (filter_name.Text != null && filter_name.Text != "")
            {
                tmpResourceQuery = resourceQuery.Where((resource r) => r.name.Contains(filter_name.Text));

                if (tmpResourceQuery.Any())
                {
                    resourceQuery = tmpResourceQuery;
                }
                else
                {
                    resourceQuery = Enumerable.Empty<resource>().AsQueryable();
                }
            }

            if (filter_description.Text != null && filter_description.Text != "")
            {
                tmpResourceQuery = resourceQuery.Where((resource r) => r.description.Contains(filter_description.Text));

                if (tmpResourceQuery.Any())
                {
                    resourceQuery = tmpResourceQuery;
                }
                else
                {
                    resourceQuery = Enumerable.Empty<resource>().AsQueryable();
                }
            }

            if (
                filter_created_from.Value != null &&
                filter_created_to.Value != null
            )
            {
                tmpResourceQuery = resourceQuery.Where((resource r) => r.created_at >= filter_created_from.Value && r.created_at < filter_created_to.Value);

                if (tmpResourceQuery.Any())
                {
                    resourceQuery = tmpResourceQuery;
                }
                else
                {
                    resourceQuery = Enumerable.Empty<resource>().AsQueryable();
                }
            }

            if (
                filter_attribute.Text != null &&
                filter_attribute.Text != ""
            )
            {
                tmpResourceQuery = resourceQuery.Where((resource r) =>
                    r.resource_eav.Where(
                        (resource_eav eav) => eav.resource_attributes.attribute.Contains(filter_attribute.Text)
                    ).Count() > 0
                );

                if (tmpResourceQuery.Any())
                {
                    resourceQuery = tmpResourceQuery;
                }
                else
                {
                    resourceQuery = Enumerable.Empty<resource>().AsQueryable();
                }
            }

            if (
                filter_attribute_value.Text != null &&
                filter_attribute_value.Text != ""
            )
            {
                tmpResourceQuery = resourceQuery.Where((resource r) =>
                    r.resource_eav.Where(
                        (resource_eav eav) => eav.resource_attribute_values.value.Contains(filter_attribute_value.Text)
                    ).Count() > 0
                );

                if (tmpResourceQuery.Any())
                {
                    resourceQuery = tmpResourceQuery;
                }
                else
                {
                    resourceQuery = Enumerable.Empty<resource>().AsQueryable();
                }
            }

            resources = resourceQuery.ToList();

            UpdateListView();
        }
    }
}

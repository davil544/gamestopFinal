using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using gamestopFinal.DataModels;
using gamestopFinal.DataAccessLayer;

namespace gamestopFinal.Admin.Inventory
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.productName = txtProdName.Text;
            product.productDescription = txtProdName.Text;
            product.productCost = float.Parse(txtProdCost.Text);

            ///adding image now
            String FilePath = flUpload.PostedFile.FileName;
            String filename = Path.GetFileName(FilePath);
            Stream fs = flUpload.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);

            product.productImage = br.ReadBytes((Int32)fs.Length);

            Session["ProductData"] = product;
            ProductTier productTier = new ProductTier();

            if (product != null)
            {
                productTier.saveProduct(product);
            }

            Response.Redirect("Products.aspx");
        }

        protected void btnClr_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }
    }
}
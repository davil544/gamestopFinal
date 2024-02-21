using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gamestopFinal.DataAccessLayer;

namespace gamestopFinal.Handlers
{
    /// <summary>
    /// Summary description for ProductImage
    /// </summary>
    public class ProductImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            byte[] theImage;
            ProductTier theTier = new ProductTier();
            Int32 ImageID = Int32.Parse(context.Request.QueryString["ID"]);

            /// if statement goes here to check for null.  If it is, load alternate image.
            if (ImageID <= 2)
            {
                theImage = theTier.getImage(ImageID);
            }
            else
            {
                theImage = theTier.getImage(-1);
            }

            context.Response.BinaryWrite(theImage);

        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}
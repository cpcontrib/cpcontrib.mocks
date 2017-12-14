using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrownPeak.CMSAPI;

/* Some Namespaces are not allowed. */
namespace CrownPeak.CMSAPI.CustomLibrary
{

	/// <summary>
	/// Used for mocking the SmptImportContext.
	/// </summary>
	/// <example>
	///   <%
	///   //basically redefine the context
	///   MockSmtpImportContext context = new MockSmtpImportContext();
	///   
	///   //have to create your own incoming email context now.
	///   context.Body = "Email Body\nvar1=value1\nvar2=value2\n";
	///   
	///   //can add attachments too
	///   context.AddEmailAttachment(new MockEmailAttachment() { StringValue = "attachment string value1" }));
	/// </example>
	public class MockSmtpImportContext
	{
		public List<MockEmailAttachment> EmailAttachments = new List<MockEmailAttachment>();
		public string Body;
		public bool AutoCreateAsset; public string AssetLabel { get; set; }
		public string From;
		public MockEmailAttachment AddEmailAttachment(MockEmailAttachment e)
		{
			this.EmailAttachments.Add(e);
			return e;
		}
		public void SetBody(params string[] args)
		{
			this.Body = string.Join("\n", args);
		}
	}
	public class MockEmailAttachment
	{
		public string StringValue;
		public string Label;
	}
}

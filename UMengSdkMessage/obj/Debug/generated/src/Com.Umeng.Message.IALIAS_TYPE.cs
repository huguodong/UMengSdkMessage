using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	[Register ("com/umeng/message/ALIAS_TYPE")]
	public abstract class ALIAS_TYPE {

		internal ALIAS_TYPE ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/interface[@name='ALIAS_TYPE']/field[@name='BAIDU']"
		[Register ("BAIDU")]
		public const string Baidu = (string) "BAIDU";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/interface[@name='ALIAS_TYPE']/field[@name='KAIXIN']"
		[Register ("KAIXIN")]
		public const string Kaixin = (string) "KAIXIN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/interface[@name='ALIAS_TYPE']/field[@name='QQ']"
		[Register ("QQ")]
		public const string Qq = (string) "QQ";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/interface[@name='ALIAS_TYPE']/field[@name='RENREN']"
		[Register ("RENREN")]
		public const string Renren = (string) "RENREN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/interface[@name='ALIAS_TYPE']/field[@name='SINA_WEIBO']"
		[Register ("SINA_WEIBO")]
		public const string SinaWeibo = (string) "SINA_WEIBO";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/interface[@name='ALIAS_TYPE']/field[@name='TENCENT_WEIBO']"
		[Register ("TENCENT_WEIBO")]
		public const string TencentWeibo = (string) "TENCENT_WEIBO";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/interface[@name='ALIAS_TYPE']/field[@name='WEIXIN']"
		[Register ("WEIXIN")]
		public const string Weixin = (string) "WEIXIN";
	}

	[System.Obsolete ("Use the 'ALIAS_TYPE' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class ALIAS_TYPEConsts : ALIAS_TYPE {

		private ALIAS_TYPEConsts ()
		{
		}
	}

}

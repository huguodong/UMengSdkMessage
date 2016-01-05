using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	[Register ("org/android/agoo/client/BaseConstants")]
	public abstract class BaseConstants {

		internal BaseConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='BINDER_ELECTION_ACTION']"
		[Register ("BINDER_ELECTION_ACTION")]
		public const string BinderElectionAction = (string) "org.android.agoo.client.ElectionReceiverService";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='BINDER_MSGRECEIVER_ACTION']"
		[Register ("BINDER_MSGRECEIVER_ACTION")]
		public const string BinderMsgreceiverAction = (string) "org.android.agoo.client.MessageReceiverService";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='CMNS_DEVICE_TOKEN']"
		[Register ("CMNS_DEVICE_TOKEN")]
		public const string CmnsDeviceToken = (string) "cmns_device_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='ERROR_APPKEY_NULL']"
		[Register ("ERROR_APPKEY_NULL")]
		public const string ErrorAppkeyNull = (string) "ERROR_APPKEY_NULL";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='ERROR_APP_SECRET_NULL']"
		[Register ("ERROR_APP_SECRET_NULL")]
		public const string ErrorAppSecretNull = (string) "ERROR_APPSECRET_NULL";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='ERROR_TTID_NULL']"
		[Register ("ERROR_TTID_NULL")]
		public const string ErrorTtidNull = (string) "ERROR_TTID_NULL";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='MESSAGE_BODY']"
		[Register ("MESSAGE_BODY")]
		public const string MessageBody = (string) "body";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='MESSAGE_ID']"
		[Register ("MESSAGE_ID")]
		public const string MessageId = (string) "id";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='MESSAGE_NOTIFICATION']"
		[Register ("MESSAGE_NOTIFICATION")]
		public const string MessageNotification = (string) "notify";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='MESSAGE_SOURCE']"
		[Register ("MESSAGE_SOURCE")]
		public const string MessageSource = (string) "message_source";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='MESSAGE_TASK_ID']"
		[Register ("MESSAGE_TASK_ID")]
		public const string MessageTaskId = (string) "task_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='MESSAGE_TYPE']"
		[Register ("MESSAGE_TYPE")]
		public const string MessageType = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='MTOP_ERRCODE_AUTH_REJECT']"
		[Register ("MTOP_ERRCODE_AUTH_REJECT")]
		public const string MtopErrcodeAuthReject = (string) "ERRCODE_AUTH_REJECT";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='BaseConstants']/field[@name='PREF_CMNS']"
		[Register ("PREF_CMNS")]
		public const string PrefCmns = (string) "pref_cmns";
	}

	[System.Obsolete ("Use the 'BaseConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class BaseConstantsConsts : BaseConstants {

		private BaseConstantsConsts ()
		{
		}
	}

}

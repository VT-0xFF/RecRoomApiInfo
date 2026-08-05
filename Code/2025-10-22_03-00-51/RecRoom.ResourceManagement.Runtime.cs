using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Async;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class XPTBWQTNCAY
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private sealed class NEFENOBNJAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public XPTBWQTNCAY CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string NDBEHBPBUER;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NEFENOBNJAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA2D0", Offset = "0x8CE88D0", VA = "0x188CEA2D0")]
			internal void QELXJMIJQPQ(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA370", Offset = "0x8CE8970", VA = "0x188CEA370")]
			internal void QEREGTCHAAZ(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly XPTBWQTNCAY JNSEPYDQQBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Dictionary<string, GameObject> PKJIUAHZTPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<string, GameObject> PTWFAVXBRXC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB1E0", Offset = "0x8CE97E0", VA = "0x188CEB1E0")]
		public XPTBWQTNCAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA8E0", Offset = "0x8CE8EE0", VA = "0x188CEA8E0", Slot = "1")]
		~XPTBWQTNCAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB000", Offset = "0x8CE9600", VA = "0x188CEB000")]
		private void YVPSNZGWMAF(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAED0", Offset = "0x8CE94D0", VA = "0x188CEAED0")]
		public GameObject OYXPSYDPRJB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAEB0", Offset = "0x8CE94B0", VA = "0x188CEAEB0")]
		public NDLOPTUCVYP<GameObject> JENOSPRNYUZ(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA810", Offset = "0x8CE8E10", VA = "0x188CEA810")]
		private GameObject EGCGJLGYSDA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CEADE0", Offset = "0x8CE93E0", VA = "0x188CEADE0")]
		public void HOKDYVDJHUE(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAF90", Offset = "0x8CE9590", VA = "0x188CEAF90")]
		public void VJBLWXQRNTN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAA00", Offset = "0x8CE9000", VA = "0x188CEAA00")]
		public NDLOPTUCVYP<GameObject> HOKDYVDJHUE(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAF10", Offset = "0x8CE9510", VA = "0x188CEAF10")]
		public bool SAVRKPPFENW(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class IXIGSWIEMOZ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3943720", Offset = "0x3941D20", VA = "0x183943720")]
		public static a SNSQZANIKZX<a>(string a) where a : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class BBHBQISBSRL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string VFKONUNTVWT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public SWBDCURZKHA<GameObject> FOBJSUETHEV;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8CE9EA0", Offset = "0x8CE84A0", VA = "0x188CE9EA0")]
			public BBHBQISBSRL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<BBHBQISBSRL> AAADSARDTTF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> LGWPYJTLUNX;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA7C0", Offset = "0x8CE8DC0", VA = "0x188CEA7C0")]
			internal bool NGBLERFYPPE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class EICZWIDMIGC : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<BBHBQISBSRL> AAADSARDTTF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private SSSKYROOASY ATDRJYHBYLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private BBHBQISBSRL XSPOOXEFGFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest CZVLCRADXDV;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public EICZWIDMIGC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8CE9F30", Offset = "0x8CE8530", VA = "0x188CE9F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA290", Offset = "0x8CE8890", VA = "0x188CEA290", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int SZQDSTYMYMT = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<BBHBQISBSRL> HIXYDDCDLWL;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA590", Offset = "0x8CE8B90", VA = "0x188CEA590")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D07FC0", Offset = "0x3D065C0", VA = "0x183D07FC0")]
		public NDLOPTUCVYP<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA480", Offset = "0x8CE8A80", VA = "0x188CEA480")]
		public NDLOPTUCVYP<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA410", Offset = "0x8CE8A10", VA = "0x188CEA410")]
		[IteratorStateMachine(typeof(EICZWIDMIGC))]
		private IEnumerator<SGCTHXNJFVM> BRLUUXPQAVG(Queue<BBHBQISBSRL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA780", Offset = "0x8CE8D80", VA = "0x188CEA780")]
		public ResourcesManager()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}

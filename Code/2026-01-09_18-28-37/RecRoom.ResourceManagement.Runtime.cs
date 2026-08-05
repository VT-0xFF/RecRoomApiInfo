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
	public class GBSDHEGUYZA
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private sealed class ZUBXSHNKXNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public GBSDHEGUYZA ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string ZTLXIBFGWSH;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ZUBXSHNKXNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x89E9690", Offset = "0x89E8A90", VA = "0x1889E9690")]
			internal void GZIJGMEWKKE(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x89E9730", Offset = "0x89E8B30", VA = "0x1889E9730")]
			internal void GZNQDSYTTVN(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly GBSDHEGUYZA GOZZDJVUTRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Dictionary<string, GameObject> EEAYFUPFAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<string, GameObject> WYZPISECEAK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89E8E30", Offset = "0x89E8230", VA = "0x1889E8E30")]
		public GBSDHEGUYZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x89E85D0", Offset = "0x89E79D0", VA = "0x1889E85D0", Slot = "1")]
		~GBSDHEGUYZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89E87A0", Offset = "0x89E7BA0", VA = "0x1889E87A0")]
		private void PITFTOJPVGT(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89E8760", Offset = "0x89E7B60", VA = "0x1889E8760")]
		public GameObject MQCUTGUBAJP(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89E8460", Offset = "0x89E7860", VA = "0x1889E8460")]
		public KOPZSJWAQQR<GameObject> DJXBYMPWWZZ(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89E8500", Offset = "0x89E7900", VA = "0x1889E8500")]
		private GameObject FYEQWAZZQAU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89E8820", Offset = "0x89E7C20", VA = "0x1889E8820")]
		public void ZPLYCBBMSZA(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89E86F0", Offset = "0x89E7AF0", VA = "0x1889E86F0")]
		public void IHGATISHELL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89E88F0", Offset = "0x89E7CF0", VA = "0x1889E88F0")]
		public KOPZSJWAQQR<GameObject> ZPLYCBBMSZA(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89E8480", Offset = "0x89E7880", VA = "0x1889E8480")]
		public bool EZSWXLGGQFU(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class FYZHTXGXFUL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x36B16E0", Offset = "0x36B0AE0", VA = "0x1836B16E0")]
		public static a YYXZUBIASIP<a>(string a) where a : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class EPQWEYXZIHV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string KZFDIIPSOWB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public YCZXWPFSJVC<GameObject> VVQOLOWDTTB;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x89E8380", Offset = "0x89E7780", VA = "0x1889E8380")]
			public EPQWEYXZIHV(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GARRZFFJODA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<EPQWEYXZIHV> RRRIBSIUHON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> LVRYNBIKHVZ;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public GARRZFFJODA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89E8410", Offset = "0x89E7810", VA = "0x1889E8410")]
			internal bool VUJOWYIEKAM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class WRGOGRJHILW : IEnumerator<QAEGIZFUAOU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private QAEGIZFUAOU FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<EPQWEYXZIHV> RRRIBSIUHON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private GARRZFFJODA FVLSEOWFJDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EPQWEYXZIHV QYUAKJNTUXA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest HBCJJJCCQDD;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private QAEGIZFUAOU NPJDJONMYRN
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public WRGOGRJHILW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x89E9330", Offset = "0x89E8730", VA = "0x1889E9330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x89E92F0", Offset = "0x89E86F0", VA = "0x1889E92F0", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int IRADVNYVGDD = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<EPQWEYXZIHV> SRYZIZSAXXL;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89E9050", Offset = "0x89E8450", VA = "0x1889E9050")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x39EFC30", Offset = "0x39EF030", VA = "0x1839EFC30")]
		public KOPZSJWAQQR<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89E8F40", Offset = "0x89E8340", VA = "0x1889E8F40")]
		public KOPZSJWAQQR<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89E91C0", Offset = "0x89E85C0", VA = "0x1889E91C0")]
		[IteratorStateMachine(typeof(WRGOGRJHILW))]
		private IEnumerator<QAEGIZFUAOU> THQMNQLQGFM(Queue<EPQWEYXZIHV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89E92B0", Offset = "0x89E86B0", VA = "0x1889E92B0")]
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CMBKFMCFILD
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class ECDNAKMOBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public CMBKFMCFILD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ECDNAKMOBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6709800", Offset = "0x6708C00", VA = "0x186709800")]
		internal void <CachePrefab>b__0(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67098A0", Offset = "0x6708CA0", VA = "0x1867098A0")]
		internal void <CachePrefab>b__1(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CMBKFMCFILD PJLHLMIHIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private Dictionary<string, GameObject> CGKHFBHGKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<string, GameObject> BDAENCJKLGB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6709680", Offset = "0x6708A80", VA = "0x186709680")]
	public CMBKFMCFILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6708D10", Offset = "0x6708110", VA = "0x186708D10", Slot = "1")]
	~CMBKFMCFILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67093C0", Offset = "0x67087C0", VA = "0x1867093C0")]
	private void MHPFENDKOFB(Scene JLPOKIGCHBG, LoadSceneMode BMGAIMADGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6708C30", Offset = "0x6708030", VA = "0x186708C30")]
	public GameObject BOIOPACGBPH(string ANCBAFIJPAE, bool PLBAMIKJOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6708CF0", Offset = "0x67080F0", VA = "0x186708CF0")]
	public global::MLDKKGKEACN<GameObject> EHLJOJAHCCH(string ANCBAFIJPAE, bool PLBAMIKJOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6709440", Offset = "0x6708840", VA = "0x186709440")]
	private GameObject OHMHGAHGEDO(string ANCBAFIJPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6708E30", Offset = "0x6708230", VA = "0x186708E30")]
	public void GEFLFGMPPOL(string ANCBAFIJPAE, GameObject IJBPCAELLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6709350", Offset = "0x6708750", VA = "0x186709350")]
	public void LDOPNOOPEII(string ANCBAFIJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6708F10", Offset = "0x6708310", VA = "0x186708F10")]
	public global::MLDKKGKEACN<GameObject> GEFLFGMPPOL(string ANCBAFIJPAE, bool PLBAMIKJOBL, bool CCKNENPJCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6708C70", Offset = "0x6708070", VA = "0x186708C70")]
	public bool CPHFINGKFPM(string ANCBAFIJPAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PPHFHBMKAMN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E8D540", Offset = "0x3E8C940", VA = "0x183E8D540")]
	public static T LJPJPMEMJON<T>(string NEIBENCLOEC) where T : UnityEngine.Object
	{
		return null;
	}
}
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class FACHFODKGIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string HGLJFCJIEGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public global::BLIGMBCADIE<GameObject> OABFIAGMPHJ;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6709940", Offset = "0x6708D40", VA = "0x186709940")]
			public FACHFODKGIH(string HGLJFCJIEGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DFPPBMONMPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<FACHFODKGIH> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public DFPPBMONMPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x67097B0", Offset = "0x6708BB0", VA = "0x1867097B0")]
			internal bool <ProcessQueue>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class KNBHPAKGEEN : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private FEEMOJCDGJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<FACHFODKGIH> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private DFPPBMONMPI <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private FACHFODKGIH <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
			[DebuggerHidden]
			public KNBHPAKGEEN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x670A000", Offset = "0x6709400", VA = "0x18670A000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x670A3C0", Offset = "0x67097C0", VA = "0x18670A3C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int BAGFGMFFBAG = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<FACHFODKGIH> GMOMMCBEJOC;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x670A5A0", Offset = "0x67099A0", VA = "0x18670A5A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3721050", Offset = "0x3720450", VA = "0x183721050")]
		public global::MLDKKGKEACN<T> LoadResourceAsync<T>(string HGLJFCJIEGN) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x670A470", Offset = "0x6709870", VA = "0x18670A470")]
		public global::MLDKKGKEACN<GameObject> LoadResourceAsync(string HGLJFCJIEGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x670A400", Offset = "0x6709800", VA = "0x18670A400")]
		[IteratorStateMachine(typeof(KNBHPAKGEEN))]
		private IEnumerator<FEEMOJCDGJP> JOILBCHNAOC(Queue<FACHFODKGIH> FBAFAIACKJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x670A6F0", Offset = "0x6709AF0", VA = "0x18670A6F0")]
		public ResourcesManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67099D0", Offset = "0x6708DD0", VA = "0x1867099D0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6709AE0", Offset = "0x6708EE0", VA = "0x186709AE0")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JBECHHDAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class PBOBNCGFFNP<T> : GPNBBGLIEEK, global::HPHOBFHHHFI<T>, JPCNLOFKBAB where T : class, GNMELKHCPEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3137D80", Offset = "0x3136780", VA = "0x183137D80")]
			internal PBOBNCGFFNP(int HMGDPLOMOOK, float[] NLINPAONOIB, POEIPLFPBLP ENNMPKEIKCC = POEIPLFPBLP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3137C80", Offset = "0x3136680", VA = "0x183137C80", Slot = "15")]
			public void CPLOAHMOJFD(T LAFPICAOEAI, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3137CB0", Offset = "0x31366B0", VA = "0x183137CB0", Slot = "16")]
			public void CPLOAHMOJFD(T LAFPICAOEAI, Transform HHNPFCDICHH, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3137CE0", Offset = "0x31366E0", VA = "0x183137CE0", Slot = "17")]
			public void HFDCJFDGIMI(T LAFPICAOEAI, [Optional] float? DKGFBEEAKHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3137D60", Offset = "0x3136760", VA = "0x183137D60", Slot = "18")]
			public void OLCIACFECIH(T IEIILDHIHCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3137D00", Offset = "0x3136700", VA = "0x183137D00", Slot = "19")]
			public MDILDCKBKMK KKAABKAJAAH(T LAFPICAOEAI)
			{
				return default(MDILDCKBKMK);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3137D20", Offset = "0x3136720", VA = "0x183137D20", Slot = "20")]
			public bool MCHJMJIJOAM(T LAFPICAOEAI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3137D40", Offset = "0x3136740", VA = "0x183137D40", Slot = "21")]
			public void NEBFNPGIFHB(T LAFPICAOEAI, EMCPICLMHHI OINHCOOFNOO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class GPNBBGLIEEK : IDisposable, JPCNLOFKBAB
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum POEIPLFPBLP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GALCBDBONFE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public GNMELKHCPEM DGOIOLAFIPD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EMCPICLMHHI BALIGGPMHGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action PNEEOIBBNAJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool DFMAFFNDDLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int FOHLPAKJEGJ;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
				public GALCBDBONFE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MJHJKPPFOGA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public GPNBBGLIEEK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public GALCBDBONFE trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
				public MJHJKPPFOGA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int ILIJKHIGHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int HMGDPLOMOOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OEJLGALKADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool IAFLCEPGHIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup FEPKGGBJCJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] KHBKEOBMKDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] JDPIEPGMFCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly PHHLOPJABBL EDFOBNPNANH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<GNMELKHCPEM, int> FFEDGDLDKAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, GALCBDBONFE> LOIGHGHMKLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly POEIPLFPBLP ENNMPKEIKCC;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int NDCDECKAEAH
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int MOEACPGDHPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x6D7790", Offset = "0x6D6190", VA = "0x1806D7790", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x645CAF0", Offset = "0x645B4F0", VA = "0x18645CAF0")]
			internal GPNBBGLIEEK(int HMGDPLOMOOK, float[] NLINPAONOIB, POEIPLFPBLP ENNMPKEIKCC = POEIPLFPBLP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459600", VA = "0x18645AC00")]
			public void CFKMIAFINNL(bool CHAMEOMNKPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x645B3E0", Offset = "0x6459DE0", VA = "0x18645B3E0", Slot = "7")]
			public MDILDCKBKMK EICKBCDDCBI(float EFJMJHLOKOL)
			{
				return default(MDILDCKBKMK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x645AC30", Offset = "0x6459630", VA = "0x18645AC30", Slot = "8")]
			public void CPLOAHMOJFD(GNMELKHCPEM LAFPICAOEAI, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x645ACC0", Offset = "0x64596C0", VA = "0x18645ACC0", Slot = "9")]
			public void CPLOAHMOJFD(GNMELKHCPEM LAFPICAOEAI, Transform HHNPFCDICHH, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x645B8D0", Offset = "0x645A2D0", VA = "0x18645B8D0")]
			public void HJDHEPGJKMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x645B850", Offset = "0x645A250", VA = "0x18645B850", Slot = "10")]
			public void HFDCJFDGIMI(GNMELKHCPEM LAFPICAOEAI, [Optional] float? DKGFBEEAKHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x645AA90", Offset = "0x6459490", VA = "0x18645AA90")]
			private void CBCNMCEPNJB(int GFDMFLGCBKB, [Optional] float? DKGFBEEAKHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x645C650", Offset = "0x645B050", VA = "0x18645C650", Slot = "11")]
			public void OLCIACFECIH(GNMELKHCPEM IEIILDHIHCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x645BBE0", Offset = "0x645A5E0", VA = "0x18645BBE0", Slot = "12")]
			public MDILDCKBKMK KKAABKAJAAH(GNMELKHCPEM LAFPICAOEAI)
			{
				return default(MDILDCKBKMK);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x645C0A0", Offset = "0x645AAA0", VA = "0x18645C0A0", Slot = "13")]
			public bool MCHJMJIJOAM(GNMELKHCPEM LAFPICAOEAI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x645C560", Offset = "0x645AF60", VA = "0x18645C560", Slot = "14")]
			public void NEBFNPGIFHB(GNMELKHCPEM LAFPICAOEAI, EMCPICLMHHI GPPMNMKKCAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x645B110", Offset = "0x6459B10", VA = "0x18645B110", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x645C1A0", Offset = "0x645ABA0", VA = "0x18645C1A0")]
			private void NCDNMDBIIMH(GALCBDBONFE BGNBGLJFMAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x645B5C0", Offset = "0x6459FC0", VA = "0x18645B5C0")]
			private void HAAMHAFBECC(GALCBDBONFE BGNBGLJFMAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x645BCF0", Offset = "0x645A6F0", VA = "0x18645BCF0")]
			private void LBGCJDDJBBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x645CA80", Offset = "0x645B480", VA = "0x18645CA80")]
			private void PLANLLFOCFJ(float NPLLDPKOMIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x645B3B0", Offset = "0x6459DB0", VA = "0x18645B3B0")]
			private void EAIMOLJHONN(GALCBDBONFE BGNBGLJFMAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x645ABF0", Offset = "0x64595F0", VA = "0x18645ABF0")]
			private void CECOGBFNGNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x645BBD0", Offset = "0x645A5D0", VA = "0x18645BBD0")]
			private void INIMIKAKAJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x645BD60", Offset = "0x645A760", VA = "0x18645BD60")]
			private void LFMLINEJAOD(CullingGroupEvent GHIBCPDICDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x645BA50", Offset = "0x645A450", VA = "0x18645BA50")]
			private void IJLNKKDOHFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct BDOOLDONAIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort GDGEKIHPAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type CNDBNOJODEI;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float JHBIBJACPNE = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float MNHENBPCCGH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float AKLGAIMMCKI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float PCBKIJPDNPM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BFJLIGJPFIA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float HIMHDLEAHCB = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BMFCKNBPKFJ = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<BDOOLDONAIE, GPNBBGLIEEK> PPJAJPEEJOB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable CGMJBFHBPPJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable JBJFECPAKBG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static JCAAIAKPOCC IAICAPKLLPF;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static JCAAIAKPOCC ELCPKKJBOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly JCAAIAKPOCC IPBAAACLLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly JCAAIAKPOCC BIOLKNHICLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JCAAIAKPOCC MNEOHELNGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private KLOMPNKHCCP MBGBNHKDKKG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool CHAMEOMNKPI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JCAAIAKPOCC GEDDDIPOAHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JCAAIAKPOCC DEIFIGOJPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JCAAIAKPOCC IMKOEDCLPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AADMBCLJKHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x18ABA10", Offset = "0x18AA410", VA = "0x1818ABA10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OGNGOLNOJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6C1030", Offset = "0x6BFA30", VA = "0x1806C1030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA2B870", Offset = "0xA2A270", VA = "0x180A2B870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6459A20", Offset = "0x6458420", VA = "0x186459A20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1044F60", Offset = "0x1043960", VA = "0x181044F60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x645A160", Offset = "0x6458B60", VA = "0x18645A160")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6459E80", Offset = "0x6458880", VA = "0x186459E80")]
		private void LKCDBIOPNPA(Scene BBIKMOACHCN, LoadSceneMode HLAMMHNAHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x645A080", Offset = "0x6458A80", VA = "0x18645A080", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x645A550", Offset = "0x6458F50", VA = "0x18645A550")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6459880", Offset = "0x6458280", VA = "0x186459880")]
		private void AMIOLCKBDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x645A320", Offset = "0x6458D20", VA = "0x18645A320")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6459EE0", Offset = "0x64588E0", VA = "0x186459EE0")]
		private void MCPDJBJJPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6459C90", Offset = "0x6458690", VA = "0x186459C90")]
		public JPCNLOFKBAB GetOrCreateCullingGroup(Type IJFIINIFCNF, int NBKHIFPPPAA, ushort GBPKBGIIKGN = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1D61C30", Offset = "0x1D60630", VA = "0x181D61C30")]
		public global::HPHOBFHHHFI<T> GetOrCreateCullingGroup<T>(int NBKHIFPPPAA, ushort GBPKBGIIKGN = 0) where T : class, GNMELKHCPEM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x645A180", Offset = "0x6458B80", VA = "0x18645A180")]
		private JPCNLOFKBAB PGKBIHACAOO(Type IJFIINIFCNF, int NBKHIFPPPAA, float[] NLINPAONOIB, ushort GBPKBGIIKGN = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1D61CE0", Offset = "0x1D606E0", VA = "0x181D61CE0")]
		private global::HPHOBFHHHFI<T> PGKBIHACAOO<T>(int NBKHIFPPPAA, float[] NLINPAONOIB, ushort GBPKBGIIKGN = 0) where T : class, GNMELKHCPEM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6459AF0", Offset = "0x64584F0", VA = "0x186459AF0")]
		public static MDILDCKBKMK FindClosestDefaultUpdateLod(float DBBLEMDADJA)
		{
			return default(MDILDCKBKMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x645A070", Offset = "0x6458A70", VA = "0x18645A070")]
		public static MDILDCKBKMK MinUpdateLod(MDILDCKBKMK MMIJLBDMLPP, MDILDCKBKMK FFNMOJPGLMG)
		{
			return default(MDILDCKBKMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x645A060", Offset = "0x6458A60", VA = "0x18645A060")]
		public static MDILDCKBKMK MaxUpdateLod(MDILDCKBKMK MMIJLBDMLPP, MDILDCKBKMK FFNMOJPGLMG)
		{
			return default(MDILDCKBKMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x645A980", Offset = "0x6459380", VA = "0x18645A980")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PHHLOPJABBL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GIOEKPADEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera NPBOHAALEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JCAAIAKPOCC CJCEPLGFOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JCBDJPDDPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JCAAIAKPOCC CLCDBMCECJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform GLPKMPEBGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JPCNLOFKBAB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int NDCDECKAEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int MOEACPGDHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MDILDCKBKMK EICKBCDDCBI(float EFJMJHLOKOL);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPLOAHMOJFD(GNMELKHCPEM LAFPICAOEAI, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPLOAHMOJFD(GNMELKHCPEM LAFPICAOEAI, Transform HHNPFCDICHH, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFDCJFDGIMI(GNMELKHCPEM LAFPICAOEAI, [Optional] float? DKGFBEEAKHF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLCIACFECIH(GNMELKHCPEM IEIILDHIHCI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MDILDCKBKMK KKAABKAJAAH(GNMELKHCPEM LAFPICAOEAI);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MCHJMJIJOAM(GNMELKHCPEM LAFPICAOEAI);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NEBFNPGIFHB(GNMELKHCPEM LAFPICAOEAI, EMCPICLMHHI OINHCOOFNOO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HPHOBFHHHFI<T> : JPCNLOFKBAB where T : class, GNMELKHCPEM
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLOAHMOJFD(T LAFPICAOEAI, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPLOAHMOJFD(T LAFPICAOEAI, Transform HHNPFCDICHH, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFDCJFDGIMI(T LAFPICAOEAI, [Optional] float? DKGFBEEAKHF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLCIACFECIH(T IEIILDHIHCI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MDILDCKBKMK KKAABKAJAAH(T LAFPICAOEAI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MCHJMJIJOAM(T LAFPICAOEAI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NEBFNPGIFHB(T LAFPICAOEAI, EMCPICLMHHI OINHCOOFNOO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GNMELKHCPEM
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform CLHKPCIOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MDILDCKBKMK IHKAOPFDPNM, MDILDCKBKMK NBMPKGLICDE);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BCEBIPIOINI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum EMCPICLMHHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MDILDCKBKMK
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AEEAAIDJOIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private MDILDCKBKMK MMCAICBMAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private MDILDCKBKMK OPOPHNBOOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, MDILDCKBKMK> KJNNEAEMFBF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool LFBPAPAJLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64597B0", Offset = "0x64581B0", VA = "0x1864597B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MDILDCKBKMK AALHPLPINID
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040")]
		get
		{
			return default(MDILDCKBKMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MDILDCKBKMK LIJMMCFLJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7790", Offset = "0x6D6190", VA = "0x1806D7790")]
		get
		{
			return default(MDILDCKBKMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6459580", Offset = "0x6457F80", VA = "0x186459580")]
	public bool CJGAFMKLKKJ(object DEGCIHEAIBD, MDILDCKBKMK MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64595F0", Offset = "0x6457FF0", VA = "0x1864595F0")]
	public bool GFAKBKOHHKC(object DEGCIHEAIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6459650", Offset = "0x6458050", VA = "0x186459650")]
	private bool KCDMNILDPDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6459800", Offset = "0x6458200", VA = "0x186459800")]
	public AEEAAIDJOIN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x645D200", Offset = "0x645BC00", VA = "0x18645D200")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x645CEB0", Offset = "0x645B8B0", VA = "0x18645CEB0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
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

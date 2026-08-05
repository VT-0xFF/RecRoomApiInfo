using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, IHILHGKIJFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class IJNABHEKKLO<T> : LENPNBFAJGG, FIHHFNLHOFG<T>, HNBDLINLDMG where T : class, FHMMDJEGHBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x369C970", Offset = "0x369B770", VA = "0x18369C970")]
			internal IJNABHEKKLO(int EGBLHNLMJDH, float[] KGOLIKPFOAO, JELOCKDHOJA JFHHCKECKJA = JELOCKDHOJA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x369C8F0", Offset = "0x369B6F0", VA = "0x18369C8F0", Slot = "10")]
			public void EJEJBLJEAIN(T DGPHOMINFCK, float HMBCCKMGEBH, CANIILHKKMB NJLIMJJEBFG = CANIILHKKMB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x369C920", Offset = "0x369B720", VA = "0x18369C920", Slot = "11")]
			public void EJEJBLJEAIN(T DGPHOMINFCK, Transform LPGGCBBMIJB, float HMBCCKMGEBH, CANIILHKKMB NJLIMJJEBFG = CANIILHKKMB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x369C950", Offset = "0x369B750", VA = "0x18369C950", Slot = "12")]
			public void KCJHGNBNEJA(T FOKDEIGKLBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class LENPNBFAJGG : IDisposable, HNBDLINLDMG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum JELOCKDHOJA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class FKOACGIBKAG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FHMMDJEGHBP KPDACFOBKOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public CANIILHKKMB NMMGEGHAAAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action DMNDDGBPOEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool GCKDMKIFFCH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int FCFMLMDMJIH;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
				public FKOACGIBKAG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class NFDCNBGLHCF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public LENPNBFAJGG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public FKOACGIBKAG trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
				public NFDCNBGLHCF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5C4FC30", Offset = "0x5C4EA30", VA = "0x185C4FC30")]
				internal void EGANEDJEFAM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int EPGOPJLHLGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int EGBLHNLMJDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int NHIJMHDNLCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool ICPHJFMOKBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup KJLBCIPKKKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] OPPMKGOHHEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] ILNHJKOJCCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly OHNIBEELDIO JOJOJMCMCEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<FHMMDJEGHBP, int> HDBAHJKADKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, FKOACGIBKAG> APDCJADNPFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly JELOCKDHOJA JFHHCKECKJA;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool FAPKGANDJEC
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x19D1650", Offset = "0x19D0450", VA = "0x1819D1650")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3BC8370", Offset = "0x3BC7170", VA = "0x183BC8370", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5C4F840", Offset = "0x5C4E640", VA = "0x185C4F840")]
			internal LENPNBFAJGG(int EGBLHNLMJDH, float[] KGOLIKPFOAO, JELOCKDHOJA JFHHCKECKJA = JELOCKDHOJA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5C4EDE0", Offset = "0x5C4DBE0", VA = "0x185C4EDE0")]
			public void JDHFLJLDFFJ(bool NPJECEMHBEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5C4E5F0", Offset = "0x5C4D3F0", VA = "0x185C4E5F0", Slot = "6")]
			public void EJEJBLJEAIN(FHMMDJEGHBP DGPHOMINFCK, float HMBCCKMGEBH, CANIILHKKMB NJLIMJJEBFG = CANIILHKKMB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5C4E200", Offset = "0x5C4D000", VA = "0x185C4E200", Slot = "9")]
			public void EJEJBLJEAIN(FHMMDJEGHBP DGPHOMINFCK, Transform LPGGCBBMIJB, float HMBCCKMGEBH, CANIILHKKMB NJLIMJJEBFG = CANIILHKKMB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5C4DF60", Offset = "0x5C4CD60", VA = "0x185C4DF60")]
			public void EBDJCCBAALC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5C4EA10", Offset = "0x5C4D810", VA = "0x185C4EA10")]
			private void HNDFKNNGMLF(int OCMJNDDMDAL, [Optional] float? HMBCCKMGEBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5C4EE10", Offset = "0x5C4DC10", VA = "0x185C4EE10", Slot = "7")]
			public void KCJHGNBNEJA(FHMMDJEGHBP FOKDEIGKLBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5C4E0B0", Offset = "0x5C4CEB0", VA = "0x185C4E0B0", Slot = "8")]
			public void ECMFIGJBFND(FHMMDJEGHBP DGPHOMINFCK, CANIILHKKMB DALHOMNCCAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5C4DCA0", Offset = "0x5C4CAA0", VA = "0x185C4DCA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5C4F4A0", Offset = "0x5C4E2A0", VA = "0x185C4F4A0")]
			private void NKJICPNJGIF(FKOACGIBKAG FKNCCHFCKBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5C4EB40", Offset = "0x5C4D940", VA = "0x185C4EB40")]
			private void IGDNHHKGFOM(FKOACGIBKAG FKNCCHFCKBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5C4E9B0", Offset = "0x5C4D7B0", VA = "0x185C4E9B0")]
			private void GPBGFLAEMPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5C4E1A0", Offset = "0x5C4CFA0", VA = "0x185C4E1A0")]
			private void ECNCJCFPIMC(float CILPHFINCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5C4F360", Offset = "0x5C4E160", VA = "0x185C4F360")]
			private void MFJCPMIBDCH(FKOACGIBKAG FKNCCHFCKBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5C4F830", Offset = "0x5C4E630", VA = "0x185C4F830")]
			private void PGJBHMALNBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5C4E9A0", Offset = "0x5C4D7A0", VA = "0x185C4E9A0")]
			private void FNKCFHEIJGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5C4E680", Offset = "0x5C4D480", VA = "0x185C4E680")]
			private void FLIKFJPBEAE(CullingGroupEvent NBOCNCDLKHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5C4F1F0", Offset = "0x5C4DFF0", VA = "0x185C4F1F0")]
			private void KDAPPEBDEAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JIKODLOAOKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort FDPOJIJMHBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type BOJHLAOKIBN;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float KOKKOHOALIG = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ALEAPGEJCKA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float AKEFGFNJLMN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float PCOKEOABKGD = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float KCJEGBJGMMK = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JDMPPDMHEJF = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float EKJKLKCHKHC = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JIKODLOAOKN, LENPNBFAJGG> PIDMNPPIHDP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable OHKMNAKHGOL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable JDLAEOFIGCC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static HJOHDOIHOEL OJNBBOALCGE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static HJOHDOIHOEL KCBANFMKDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HJOHDOIHOEL NKOEPCGLLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HJOHDOIHOEL KMDJPBEOBHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HJOHDOIHOEL HBIDLMFHHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private KFKJPENGGJI PDPNBJJABEE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool NPJECEMHBEO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HJOHDOIHOEL JGIGHGHKPHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HJOHDOIHOEL NAOOABFPNMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HJOHDOIHOEL CKCNAJFIMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MPGAFDNFCPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBC1270", Offset = "0xBC0070", VA = "0x180BC1270", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FDLNGONGGJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B2CF0", Offset = "0x7B1AF0", VA = "0x1807B2CF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D00", Offset = "0x7B1B00", VA = "0x1807B2D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C4CA20", Offset = "0x5C4B820", VA = "0x185C4CA20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D4D0", Offset = "0x5C4C2D0", VA = "0x185C4D4D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D4B0", Offset = "0x5C4C2B0", VA = "0x185C4D4B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D040", Offset = "0x5C4BE40", VA = "0x185C4D040")]
		private void JMPGEMKALNE(Scene GJBLGBOBAMI, LoadSceneMode BPBBIDFIPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D3D0", Offset = "0x5C4C1D0", VA = "0x185C4D3D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D730", Offset = "0x5C4C530", VA = "0x185C4D730")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D0B0", Offset = "0x5C4BEB0", VA = "0x185C4D0B0")]
		private void NGHGBAAPEPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D4F0", Offset = "0x5C4C2F0", VA = "0x185C4D4F0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D250", Offset = "0x5C4C050", VA = "0x185C4D250")]
		private void OLADEBLJPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C4CC40", Offset = "0x5C4BA40", VA = "0x185C4CC40")]
		public HNBDLINLDMG GetOrCreateCullingGroup(Type LEINLLEEBLD, int FBCLIKIKGKO, ushort HMCJKMMDFEH = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2214010", Offset = "0x2212E10", VA = "0x182214010")]
		public FIHHFNLHOFG<T> GetOrCreateCullingGroup<T>(int FBCLIKIKGKO, ushort HMCJKMMDFEH = 0) where T : class, FHMMDJEGHBP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C4CE60", Offset = "0x5C4BC60", VA = "0x185C4CE60")]
		private HNBDLINLDMG HJCFPFIKKMI(Type LEINLLEEBLD, int FBCLIKIKGKO, float[] KGOLIKPFOAO, ushort HMCJKMMDFEH = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22140B0", Offset = "0x2212EB0", VA = "0x1822140B0")]
		private FIHHFNLHOFG<T> HJCFPFIKKMI<T>(int FBCLIKIKGKO, float[] KGOLIKPFOAO, ushort HMCJKMMDFEH = 0) where T : class, FHMMDJEGHBP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C4CAE0", Offset = "0x5C4B8E0", VA = "0x185C4CAE0")]
		public static CMHABJECOFN FindClosestDefaultUpdateLod(float ELJIDFALNGP)
		{
			return default(CMHABJECOFN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78C000", Offset = "0x78AE00", VA = "0x18078C000")]
		public static CMHABJECOFN MinUpdateLod(CMHABJECOFN FILNEPFGMKD, CMHABJECOFN DOBHHLIJFOD)
		{
			return default(CMHABJECOFN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C4D0A0", Offset = "0x5C4BEA0", VA = "0x185C4D0A0")]
		public static CMHABJECOFN MaxUpdateLod(CMHABJECOFN FILNEPFGMKD, CMHABJECOFN DOBHHLIJFOD)
		{
			return default(CMHABJECOFN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C4DBA0", Offset = "0x5C4C9A0", VA = "0x185C4DBA0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OHNIBEELDIO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PKBOGNNGBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera NLDMBEGCPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HJOHDOIHOEL EHDIFMOHPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FNHMMHOCLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HJOHDOIHOEL LMDEKEPAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform JEENLNMLMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HNBDLINLDMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FAPKGANDJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJEJBLJEAIN(FHMMDJEGHBP DGPHOMINFCK, float HMBCCKMGEBH, CANIILHKKMB NJLIMJJEBFG = CANIILHKKMB.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCJHGNBNEJA(FHMMDJEGHBP FOKDEIGKLBP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECMFIGJBFND(FHMMDJEGHBP DGPHOMINFCK, CANIILHKKMB LMNOCDKCIOG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FIHHFNLHOFG<T> : HNBDLINLDMG where T : class, FHMMDJEGHBP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJEJBLJEAIN(T DGPHOMINFCK, float HMBCCKMGEBH, CANIILHKKMB NJLIMJJEBFG = CANIILHKKMB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJEJBLJEAIN(T DGPHOMINFCK, Transform LPGGCBBMIJB, float HMBCCKMGEBH, CANIILHKKMB NJLIMJJEBFG = CANIILHKKMB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCJHGNBNEJA(T FOKDEIGKLBP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FHMMDJEGHBP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform ILMBKONFEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CMHABJECOFN FAGNKKLHAKO, CMHABJECOFN MKIGNGOBIGF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool KMOAILLCHKL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum CANIILHKKMB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CMHABJECOFN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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

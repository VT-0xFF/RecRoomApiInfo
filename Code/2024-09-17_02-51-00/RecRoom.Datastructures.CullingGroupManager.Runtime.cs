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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, KOBKNGEGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class EOCHBIPGHHK<T> : ILJIGHJMCGI, FGNHGLPKBBO<T>, NHDPODLODNG where T : class, PLHBJJNCKPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3A5CB30", Offset = "0x3A5B530", VA = "0x183A5CB30")]
			internal EOCHBIPGHHK(int MBPDFBGMJAK, float[] MLJGJIPHHAC, OAJGPEPOABD EBKIPALBMBN = OAJGPEPOABD.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3A5CAB0", Offset = "0x3A5B4B0", VA = "0x183A5CAB0", Slot = "10")]
			public void FABNFHGMHGJ(T GHMNBJIOGAM, float PPAGJHCGANB, IDPKEMCPFEK DHIBHPAILJD = IDPKEMCPFEK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3A5CAE0", Offset = "0x3A5B4E0", VA = "0x183A5CAE0", Slot = "11")]
			public void FABNFHGMHGJ(T GHMNBJIOGAM, Transform CDMMIAOAIAK, float PPAGJHCGANB, IDPKEMCPFEK DHIBHPAILJD = IDPKEMCPFEK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3A5CB10", Offset = "0x3A5B510", VA = "0x183A5CB10", Slot = "12")]
			public void MBEEDABKNGP(T HPFINHLPMLF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class ILJIGHJMCGI : IDisposable, NHDPODLODNG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum OAJGPEPOABD : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OKIEMAFLFHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public PLHBJJNCKPL IECKENPPIJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public IDPKEMCPFEK GKJEPDEMBDB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action CCFKGKDHJNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool DMEFLFGKENE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int OAGDGHBELJN;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
				public OKIEMAFLFHC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class EAMNLAPPKOP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public ILJIGHJMCGI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public OKIEMAFLFHC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
				public EAMNLAPPKOP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6C20750", Offset = "0x6C1F150", VA = "0x186C20750")]
				internal void ALDEOJHGKLF()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NHCEEPNIBME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int MBPDFBGMJAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int PNEOLMDLHBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool HHCLANPDDNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup INJLNJOJGAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] DMLHBHGNIGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] DIFFAPPBDFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly PKJADFOHEBM GDGJPCNEJIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<PLHBJJNCKPL, int> HAOHMOMEKEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, OKIEMAFLFHC> LGPBOMCIODG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly OAJGPEPOABD EBKIPALBMBN;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IKMHLKIBJGA
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xAC0350", Offset = "0xABED50", VA = "0x180AC0350")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x47C8D90", Offset = "0x47C7790", VA = "0x1847C8D90", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6C223E0", Offset = "0x6C20DE0", VA = "0x186C223E0")]
			internal ILJIGHJMCGI(int MBPDFBGMJAK, float[] MLJGJIPHHAC, OAJGPEPOABD EBKIPALBMBN = OAJGPEPOABD.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6C208B0", Offset = "0x6C1F2B0", VA = "0x186C208B0")]
			public void CINGHHGFAOB(bool PGBODBNFMND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6C20C10", Offset = "0x6C1F610", VA = "0x186C20C10", Slot = "6")]
			public void FABNFHGMHGJ(PLHBJJNCKPL GHMNBJIOGAM, float PPAGJHCGANB, IDPKEMCPFEK DHIBHPAILJD = IDPKEMCPFEK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6C20CA0", Offset = "0x6C1F6A0", VA = "0x186C20CA0", Slot = "9")]
			public void FABNFHGMHGJ(PLHBJJNCKPL GHMNBJIOGAM, Transform CDMMIAOAIAK, float PPAGJHCGANB, IDPKEMCPFEK DHIBHPAILJD = IDPKEMCPFEK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6C22020", Offset = "0x6C20A20", VA = "0x186C22020")]
			public void OAPGINJBMKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C217B0", Offset = "0x6C201B0", VA = "0x186C217B0")]
			private void LMAKOIJGBPN(int HGFDMIDEFHN, [Optional] float? PPAGJHCGANB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6C218E0", Offset = "0x6C202E0", VA = "0x186C218E0", Slot = "7")]
			public void MBEEDABKNGP(PLHBJJNCKPL HPFINHLPMLF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6C216C0", Offset = "0x6C200C0", VA = "0x186C216C0", Slot = "8")]
			public void LJAOHMLBGKP(PLHBJJNCKPL GHMNBJIOGAM, IDPKEMCPFEK JJOJAMBONBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C208F0", Offset = "0x6C1F2F0", VA = "0x186C208F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6C21CC0", Offset = "0x6C206C0", VA = "0x186C21CC0")]
			private void NPCDJKDKFMM(OKIEMAFLFHC MIINOKBIAOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6C22170", Offset = "0x6C20B70", VA = "0x186C22170")]
			private void POJPJGGLPFK(OKIEMAFLFHC MIINOKBIAOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6C211D0", Offset = "0x6C1FBD0", VA = "0x186C211D0")]
			private void IIFICIJGGMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C20BB0", Offset = "0x6C1F5B0", VA = "0x186C20BB0")]
			private void EAANHJADEGP(float BKOJCILPMLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6C21090", Offset = "0x6C1FA90", VA = "0x186C21090")]
			private void IGHPEDOBDDA(OKIEMAFLFHC MIINOKBIAOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6C208E0", Offset = "0x6C1F2E0", VA = "0x186C208E0")]
			private void DCOMKMEMHNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6C208A0", Offset = "0x6C1F2A0", VA = "0x186C208A0")]
			private void AGGFNGEEFMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C21230", Offset = "0x6C1FC30", VA = "0x186C21230")]
			private void KIGFJCONEIJ(CullingGroupEvent KGKLIIHFDBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C21550", Offset = "0x6C1FF50", VA = "0x186C21550")]
			private void KILNDOFMMME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct IHJMIIPAEEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort GKDIJMPHEFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type KIBGKHHGDKH;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float MMHHONFIKBJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float PDDGILCHDLH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FFCAIAIOGJN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NHEODLOEHII = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float EMDJFOLEDLK = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float CPMEGBNHHDN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float OEIICFNOEKL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<IHJMIIPAEEN, ILJIGHJMCGI> JLNCBHJEOGK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable JOAAKGPLCPI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable NIBPNDCNJPH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static GHNLMGKLHKE MFOIKMCEFHP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static GHNLMGKLHKE PFJKPDNINGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly GHNLMGKLHKE HAFNDAMCEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GHNLMGKLHKE GKHPPILLGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GHNLMGKLHKE OJLAOFJFDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EPGCCCKMEBG GHDNIMLAHNO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool PGBODBNFMND;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GHNLMGKLHKE EMKEIOGAKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GHNLMGKLHKE ACLALCFPMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GHNLMGKLHKE LOFILHMFMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NKEDCLEGNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1604A60", Offset = "0x1603460", VA = "0x181604A60", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NMOKEGOFGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xC46710", Offset = "0xC45110", VA = "0x180C46710", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD234D0", Offset = "0xD21ED0", VA = "0x180D234D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F510", Offset = "0x6C1DF10", VA = "0x186C1F510", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FFB0", Offset = "0x6C1E9B0", VA = "0x186C1FFB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FF90", Offset = "0x6C1E990", VA = "0x186C1FF90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FE50", Offset = "0x6C1E850", VA = "0x186C1FE50")]
		private void OJJGHAGKKLE(Scene PAANLKAJOCM, LoadSceneMode COEMAIGHGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FEB0", Offset = "0x6C1E8B0", VA = "0x186C1FEB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C20200", Offset = "0x6C1EC00", VA = "0x186C20200")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FCA0", Offset = "0x6C1E6A0", VA = "0x186C1FCA0")]
		private void IECPKGKMMHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FFD0", Offset = "0x6C1E9D0", VA = "0x186C1FFD0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F7B0", Offset = "0x6C1E1B0", VA = "0x186C1F7B0")]
		private void ECFAMMFGODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FA80", Offset = "0x6C1E480", VA = "0x186C1FA80")]
		public NHDPODLODNG GetOrCreateCullingGroup(Type MENCEHJBLPD, int EDDKBJEJPDJ, ushort GLMHNIMIAFF = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6980", Offset = "0x2BA5380", VA = "0x182BA6980")]
		public FGNHGLPKBBO<T> GetOrCreateCullingGroup<T>(int EDDKBJEJPDJ, ushort GLMHNIMIAFF = 0) where T : class, PLHBJJNCKPL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F5D0", Offset = "0x6C1DFD0", VA = "0x186C1F5D0")]
		private NHDPODLODNG BCNACMLMGNO(Type MENCEHJBLPD, int EDDKBJEJPDJ, float[] MLJGJIPHHAC, ushort GLMHNIMIAFF = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6700", Offset = "0x2BA5100", VA = "0x182BA6700")]
		private FGNHGLPKBBO<T> BCNACMLMGNO<T>(int EDDKBJEJPDJ, float[] MLJGJIPHHAC, ushort GLMHNIMIAFF = 0) where T : class, PLHBJJNCKPL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F920", Offset = "0x6C1E320", VA = "0x186C1F920")]
		public static MGNMBPEAPIF FindClosestDefaultUpdateLod(float BHNALIAKMMO)
		{
			return default(MGNMBPEAPIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C5460", Offset = "0x8C3E60", VA = "0x1808C5460")]
		public static MGNMBPEAPIF MinUpdateLod(MGNMBPEAPIF JAIMNOILKOI, MGNMBPEAPIF NANCENKOONM)
		{
			return default(MGNMBPEAPIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FE40", Offset = "0x6C1E840", VA = "0x186C1FE40")]
		public static MGNMBPEAPIF MaxUpdateLod(MGNMBPEAPIF JAIMNOILKOI, MGNMBPEAPIF NANCENKOONM)
		{
			return default(MGNMBPEAPIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C20650", Offset = "0x6C1F050", VA = "0x186C20650")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PKJADFOHEBM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FGIFGDHDPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera GKKDLJCCILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GHNLMGKLHKE JFDGMABCAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FNKNPNKODAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GHNLMGKLHKE FHJBDDDDHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform EFGFBAEBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NHDPODLODNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IKMHLKIBJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FABNFHGMHGJ(PLHBJJNCKPL GHMNBJIOGAM, float PPAGJHCGANB, IDPKEMCPFEK DHIBHPAILJD = IDPKEMCPFEK.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBEEDABKNGP(PLHBJJNCKPL HPFINHLPMLF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJAOHMLBGKP(PLHBJJNCKPL GHMNBJIOGAM, IDPKEMCPFEK OMHNLAGFMKG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FGNHGLPKBBO<T> : NHDPODLODNG where T : class, PLHBJJNCKPL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FABNFHGMHGJ(T GHMNBJIOGAM, float PPAGJHCGANB, IDPKEMCPFEK DHIBHPAILJD = IDPKEMCPFEK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FABNFHGMHGJ(T GHMNBJIOGAM, Transform CDMMIAOAIAK, float PPAGJHCGANB, IDPKEMCPFEK DHIBHPAILJD = IDPKEMCPFEK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBEEDABKNGP(T HPFINHLPMLF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PLHBJJNCKPL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform FLDLBOHKNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MGNMBPEAPIF FOLFJJOEOPG, MGNMBPEAPIF EDIGGMGOMPC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool ABGDCOOCPNG);
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

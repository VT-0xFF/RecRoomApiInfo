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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, FGKPNLPNGDC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KCNCOEKKIMD<T> : HCMODMPNMCF, BCPLFMPGDKK<T>, OHGALMMLAOE where T : class, IEEDHJFAECG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4083F40", Offset = "0x4082740", VA = "0x184083F40")]
			internal KCNCOEKKIMD(int EHEKEGFMHOF, float[] LADIOLAJFOD, BILJJAAAJNC KDDDBGOEEIP = BILJJAAAJNC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4083EF0", Offset = "0x40826F0", VA = "0x184083EF0", Slot = "10")]
			public void CNLMKNIMMKA(T GHDJADLHPAA, float PBKMMDBNFGD, COGJEJCHONG EPMCPBAALDM = COGJEJCHONG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4083EC0", Offset = "0x40826C0", VA = "0x184083EC0", Slot = "11")]
			public void CNLMKNIMMKA(T GHDJADLHPAA, Transform AGGHIENPFBE, float PBKMMDBNFGD, COGJEJCHONG EPMCPBAALDM = COGJEJCHONG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4083F20", Offset = "0x4082720", VA = "0x184083F20", Slot = "12")]
			public void GALPDKBCKMP(T DEFBNMAALBB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HCMODMPNMCF : IDisposable, OHGALMMLAOE
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum BILJJAAAJNC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class MPDLEGLBIBE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public IEEDHJFAECG CLFKIENLAIL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public COGJEJCHONG IIGJFOBMGIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action BDGLFGOJFAJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool DBDGOJIHOBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int CFDBFCCMKIM;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
				public MPDLEGLBIBE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class JDEFHNBFEOH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public HCMODMPNMCF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public MPDLEGLBIBE trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
				public JDEFHNBFEOH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6825030", Offset = "0x6823830", VA = "0x186825030")]
				internal void CDNMAJBAAOK()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int DCPPHFMAKGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int EHEKEGFMHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int GAPGEKFLOJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool NIKEPOPPBPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup MLBHCBFHKKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] OBLIGPDJFEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] OINAKABMFJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly EMLHNFAJPJI NALLEMLECHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<IEEDHJFAECG, int> HACFPDLNOFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, MPDLEGLBIBE> OKHLBDGIIEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly BILJJAAAJNC KDDDBGOEEIP;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool AGPEAAHABFD
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xEF9D40", Offset = "0xEF8540", VA = "0x180EF9D40")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x43FA410", Offset = "0x43F8C10", VA = "0x1843FA410", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6824C40", Offset = "0x6823440", VA = "0x186824C40")]
			internal HCMODMPNMCF(int EHEKEGFMHOF, float[] LADIOLAJFOD, BILJJAAAJNC KDDDBGOEEIP = BILJJAAAJNC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x68247F0", Offset = "0x6822FF0", VA = "0x1868247F0")]
			public void KBEOGAPCOEL(bool BIFBPGMONNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6823430", Offset = "0x6821C30", VA = "0x186823430", Slot = "6")]
			public void CNLMKNIMMKA(IEEDHJFAECG GHDJADLHPAA, float PBKMMDBNFGD, COGJEJCHONG EPMCPBAALDM = COGJEJCHONG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x68234C0", Offset = "0x6821CC0", VA = "0x1868234C0", Slot = "9")]
			public void CNLMKNIMMKA(IEEDHJFAECG GHDJADLHPAA, Transform AGGHIENPFBE, float PBKMMDBNFGD, COGJEJCHONG EPMCPBAALDM = COGJEJCHONG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6824AF0", Offset = "0x68232F0", VA = "0x186824AF0")]
			public void ODGLDNBDDCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68249C0", Offset = "0x68231C0", VA = "0x1868249C0")]
			private void MOEGBGJCFIB(int JBDLDJOINOF, [Optional] float? PBKMMDBNFGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6823FA0", Offset = "0x68227A0", VA = "0x186823FA0", Slot = "7")]
			public void GALPDKBCKMP(IEEDHJFAECG DEFBNMAALBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68238C0", Offset = "0x68220C0", VA = "0x1868238C0", Slot = "8")]
			public void DNFBELHILBG(IEEDHJFAECG GHDJADLHPAA, COGJEJCHONG FNANHDBDGHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6823CE0", Offset = "0x68224E0", VA = "0x186823CE0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x68230D0", Offset = "0x68218D0", VA = "0x1868230D0")]
			private void AFNHAEMHEMH(MPDLEGLBIBE AJOKGAMELOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6824580", Offset = "0x6822D80", VA = "0x186824580")]
			private void JNAABMDCOBC(MPDLEGLBIBE AJOKGAMELOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6824500", Offset = "0x6822D00", VA = "0x186824500")]
			private void HPAIMEKHGKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6824960", Offset = "0x6823160", VA = "0x186824960")]
			private void LICGKJDPHKH(float PNBNBIDOECN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6824820", Offset = "0x6823020", VA = "0x186824820")]
			private void KKMBCJBONBG(MPDLEGLBIBE AJOKGAMELOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6824570", Offset = "0x6822D70", VA = "0x186824570")]
			private void JMABDICGKGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6824560", Offset = "0x6822D60", VA = "0x186824560")]
			private void JAACOGGHENB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68239B0", Offset = "0x68221B0", VA = "0x1868239B0")]
			private void DNOKFIFOPJE(CullingGroupEvent OPANKILNLBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6824390", Offset = "0x6822B90", VA = "0x186824390")]
			private void HOFEBIKHJOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct BHKPDHKIKBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort JJOIPCLCFGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type OLOHLDBGIAI;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float GPCILMAPBPJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float MGOKGNEIIFB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float PGIBKNHAELL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float BBCKGGFPAIK = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BBDJMNJHAJE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float AAGANKPOLJC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GAKMBIHFPJA = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<BHKPDHKIKBJ, HCMODMPNMCF> NABNFHCEAPJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable OBNPNOIFAKK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable KCIPIKLKBKO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static LFHDLKLNBFG OBDDLMBAKDC;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LFHDLKLNBFG BIMKOEFFLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LFHDLKLNBFG FOJIPHHDICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LFHDLKLNBFG HJGKJMPAJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LFHDLKLNBFG OJACOANBDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JLAFAKOGFMB IDAPFGHOJGE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool BIFBPGMONNF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LFHDLKLNBFG POADHMFBPAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LFHDLKLNBFG MNHGOOJIMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LFHDLKLNBFG OEGGCEPCJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JMLEGAGJDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF78700", Offset = "0xF76F00", VA = "0x180F78700", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FEGOCGBHLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x993570", Offset = "0x991D70", VA = "0x180993570", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA10950", Offset = "0xA0F150", VA = "0x180A10950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6821E90", Offset = "0x6820690", VA = "0x186821E90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6822930", Offset = "0x6821130", VA = "0x186822930")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6822910", Offset = "0x6821110", VA = "0x186822910")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68227D0", Offset = "0x6820FD0", VA = "0x1868227D0")]
		private void OADAKDLEBKP(Scene HBKOGPCMPEI, LoadSceneMode MCJDOPPFHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6822830", Offset = "0x6821030", VA = "0x186822830", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6822B80", Offset = "0x6821380", VA = "0x186822B80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6821F50", Offset = "0x6820750", VA = "0x186821F50")]
		private void DPLLDBMOOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6822950", Offset = "0x6821150", VA = "0x186822950")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68220F0", Offset = "0x68208F0", VA = "0x1868220F0")]
		private void EEGLGLFABGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68223C0", Offset = "0x6820BC0", VA = "0x1868223C0")]
		public OHGALMMLAOE GetOrCreateCullingGroup(Type IIFPICIEBJL, int GHHCNGJLPAA, ushort OFDKJDKFEIG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28D8590", Offset = "0x28D6D90", VA = "0x1828D8590")]
		public BCPLFMPGDKK<T> GetOrCreateCullingGroup<T>(int GHHCNGJLPAA, ushort OFDKJDKFEIG = 0) where T : class, IEEDHJFAECG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68225E0", Offset = "0x6820DE0", VA = "0x1868225E0")]
		private OHGALMMLAOE KMLHCBCKKFJ(Type IIFPICIEBJL, int GHHCNGJLPAA, float[] LADIOLAJFOD, ushort OFDKJDKFEIG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28D8640", Offset = "0x28D6E40", VA = "0x1828D8640")]
		private BCPLFMPGDKK<T> KMLHCBCKKFJ<T>(int GHHCNGJLPAA, float[] LADIOLAJFOD, ushort OFDKJDKFEIG = 0) where T : class, IEEDHJFAECG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6822260", Offset = "0x6820A60", VA = "0x186822260")]
		public static LPELNIAIFBH FindClosestDefaultUpdateLod(float MPNOCFMJGCP)
		{
			return default(LPELNIAIFBH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x870650", Offset = "0x86EE50", VA = "0x180870650")]
		public static LPELNIAIFBH MinUpdateLod(LPELNIAIFBH DFHOGOIIAJN, LPELNIAIFBH FIJFODOLDKI)
		{
			return default(LPELNIAIFBH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68227C0", Offset = "0x6820FC0", VA = "0x1868227C0")]
		public static LPELNIAIFBH MaxUpdateLod(LPELNIAIFBH DFHOGOIIAJN, LPELNIAIFBH FIJFODOLDKI)
		{
			return default(LPELNIAIFBH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6822FD0", Offset = "0x68217D0", VA = "0x186822FD0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EMLHNFAJPJI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MOCDDOEDDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera EIOLNNOMBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LFHDLKLNBFG OJHLDPIEGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ABKKBJFJGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LFHDLKLNBFG JJNMCLAMAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform HBCHOPMGKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OHGALMMLAOE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool AGPEAAHABFD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNLMKNIMMKA(IEEDHJFAECG GHDJADLHPAA, float PBKMMDBNFGD, COGJEJCHONG EPMCPBAALDM = COGJEJCHONG.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GALPDKBCKMP(IEEDHJFAECG DEFBNMAALBB);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNFBELHILBG(IEEDHJFAECG GHDJADLHPAA, COGJEJCHONG JFAILNHJKIM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BCPLFMPGDKK<T> : OHGALMMLAOE where T : class, IEEDHJFAECG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNLMKNIMMKA(T GHDJADLHPAA, float PBKMMDBNFGD, COGJEJCHONG EPMCPBAALDM = COGJEJCHONG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNLMKNIMMKA(T GHDJADLHPAA, Transform AGGHIENPFBE, float PBKMMDBNFGD, COGJEJCHONG EPMCPBAALDM = COGJEJCHONG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GALPDKBCKMP(T DEFBNMAALBB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IEEDHJFAECG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform MCHMJHAODPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(LPELNIAIFBH MENHELCNPAE, LPELNIAIFBH DLLGGKJLENF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EJKKPOHPAHN);
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

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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, EKACKMKGLEA
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class IKACCOEKCCL : IDisposable, IGDKDJNIGJL
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int JFFGDPDIDGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int LHJNCHNNCDG
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void FJALDHMCBOJ();

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void IKNBJHEBOIB(bool JIPKNMJEIMK);

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			protected IKACCOEKCCL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class LOCCEOOPLOH<T> : IKACCOEKCCL, global::DNPJBDDGHII<T>, IGDKDJNIGJL where T : HIOFLADKOEI
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum IHEKJCMJCGK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class PCCDHDKAIOD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T DHANKKIIMNB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public GCKCPJOKLLJ ICPPLLCDKPC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action IEHGMOLBCGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool HKJLIGFKFFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int PDGADEKDACK;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
				public PCCDHDKAIOD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class OBHHPOHPKBJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public LOCCEOOPLOH<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public PCCDHDKAIOD trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
				public OBHHPOHPKBJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int KLFLGLPHPKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GIBLHOEPHAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int JMOOFNGCBCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool FNFCOIPJPFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup BEMKGMDDKAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] BBIPPDJKFHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] MAECPFDDDOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly PINMOMNKPHL AGONKCODOEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> DOBPODCDGLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, PCCDHDKAIOD> GLLLJALBABJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly IHEKJCMJCGK JNHDJOJKHIA;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int JFFGDPDIDGM
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int LHJNCHNNCDG
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x6866E0", Offset = "0x684EE0", VA = "0x1806866E0", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x54264A0", Offset = "0x5424CA0", VA = "0x1854264A0")]
			internal LOCCEOOPLOH(int GIBLHOEPHAF, float[] FPPCMIKIJGN, IHEKJCMJCGK JNHDJOJKHIA = IHEKJCMJCGK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5425520", Offset = "0x5423D20", VA = "0x185425520", Slot = "11")]
			public override void IKNBJHEBOIB(bool JIPKNMJEIMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5425110", Offset = "0x5423910", VA = "0x185425110", Slot = "12")]
			public HNFHMBFMBKC HPBECHJPNCC(float LCKAAHNJMCH)
			{
				return default(HNFHMBFMBKC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5425C00", Offset = "0x5424400", VA = "0x185425C00", Slot = "13")]
			public void NLKJJINIDJF(T DEGGOOGCHFA, float LOBHAECCNKO, GCKCPJOKLLJ HJPFMGBDNKP = GCKCPJOKLLJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5425CA0", Offset = "0x54244A0", VA = "0x185425CA0", Slot = "14")]
			public void NLKJJINIDJF(T DEGGOOGCHFA, Transform FKAGOJKLCIM, float LOBHAECCNKO, GCKCPJOKLLJ HJPFMGBDNKP = GCKCPJOKLLJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5424E00", Offset = "0x5423600", VA = "0x185424E00", Slot = "8")]
			public override void FJALDHMCBOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x54245B0", Offset = "0x5422DB0", VA = "0x1854245B0", Slot = "15")]
			public void CIOBEMCJLJM(T DEGGOOGCHFA, [Optional] float? LOBHAECCNKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5424CC0", Offset = "0x54234C0", VA = "0x185424CC0")]
			private void EDPDOJLMOPN(int AKLHCIJHJKB, [Optional] float? LOBHAECCNKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5425860", Offset = "0x5424060", VA = "0x185425860", Slot = "16")]
			public void NHIAFFMKOAF(T NKHFENAOJGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5425550", Offset = "0x5423D50", VA = "0x185425550", Slot = "17")]
			public HNFHMBFMBKC JIDKOGILIEJ(T DEGGOOGCHFA)
			{
				return default(HNFHMBFMBKC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x54263A0", Offset = "0x5424BA0", VA = "0x1854263A0", Slot = "18")]
			public bool OPMBNFJHKNC(T DEGGOOGCHFA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x54256E0", Offset = "0x5423EE0", VA = "0x1854256E0", Slot = "19")]
			public void NABEINHAABM(T DEGGOOGCHFA, GCKCPJOKLLJ DFCKILDODLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5424940", Offset = "0x5423140", VA = "0x185424940", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5425170", Offset = "0x5423970", VA = "0x185425170")]
			private void IFANHKGKMJA(PCCDHDKAIOD HHHKJDMNJBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5426120", Offset = "0x5424920", VA = "0x185426120")]
			private void NPHDKJEKDGI(PCCDHDKAIOD HHHKJDMNJBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x54257F0", Offset = "0x5423FF0", VA = "0x1854257F0")]
			private void NBKPEEAHOLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5425670", Offset = "0x5423E70", VA = "0x185425670")]
			private void KCIAGEDGMBF(float NIPONCEJAIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5424540", Offset = "0x5422D40", VA = "0x185424540")]
			private void ADOBLNOBCDO(PCCDHDKAIOD HHHKJDMNJBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5424F80", Offset = "0x5423780", VA = "0x185424F80")]
			private void FJIJOMNNBMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5424580", Offset = "0x5422D80", VA = "0x185424580")]
			private void BGJEFMOLGMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5424630", Offset = "0x5422E30", VA = "0x185424630")]
			private void DHJIKPENCPM(CullingGroupEvent CJNNOIGAIML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5424FA0", Offset = "0x54237A0", VA = "0x185424FA0")]
			private void HEPDMPNJJGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct NDLCCDIGHDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort EOABGBEGJNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type OEIPOKGNFCD;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float EFJKLLOGOJI = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float GCINMBNMLBN = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float HIMOOHAJCIA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CBDALMILCKP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float DIGFJALNMKB = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OHJOMEIFOGG = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KHFAJFBIEIC = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<NDLCCDIGHDL, IKACCOEKCCL> MDGGGHKPCBH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DGGIGOHBNNE;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable JFFEIKOLONK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DAPLAJJDDGM MJBMBHELLOL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DAPLAJJDDGM ACKOBPBHDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DAPLAJJDDGM HNIDHMJKMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DAPLAJJDDGM PDNEMHOOLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DAPLAJJDDGM LLGMFMLHMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EMIHBMNJEOE ENNDMKDMLJE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool JIPKNMJEIMK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DAPLAJJDDGM LNOHICDNGKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DAPLAJJDDGM GGAOGICMPKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DAPLAJJDDGM MNLJNOPLIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MCAFKBKAKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x785750", Offset = "0x783F50", VA = "0x180785750", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EEAMOPDOABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6ABFC0", Offset = "0x6AA7C0", VA = "0x1806ABFC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6ABFB0", Offset = "0x6AA7B0", VA = "0x1806ABFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x41EC650", Offset = "0x41EAE50", VA = "0x1841EC650", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x343DDD0", Offset = "0x343C5D0", VA = "0x18343DDD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x41ECDB0", Offset = "0x41EB5B0", VA = "0x1841ECDB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x41EC6F0", Offset = "0x41EAEF0", VA = "0x1841EC6F0")]
		private void BEPLAOFLOIK(Scene KBLKDNCIAFJ, LoadSceneMode CHFDMDJDKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41ECD00", Offset = "0x41EB500", VA = "0x1841ECD00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x41ED030", Offset = "0x41EB830", VA = "0x1841ED030")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x41ECB60", Offset = "0x41EB360", VA = "0x1841ECB60")]
		private void NHPOCLBKIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x41ECDD0", Offset = "0x41EB5D0", VA = "0x1841ECDD0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x41EC940", Offset = "0x41EB140", VA = "0x1841EC940")]
		private void MHFCINFMAOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1182BC0", Offset = "0x11813C0", VA = "0x181182BC0")]
		public global::DNPJBDDGHII<T> GetOrCreateCullingGroup<T>(int GHDAGJGAJPB, ushort HCMMKCPLKBO = 0) where T : HIOFLADKOEI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1182C70", Offset = "0x1181470", VA = "0x181182C70")]
		private global::DNPJBDDGHII<T> NNMKDELNHJH<T>(int GHDAGJGAJPB, float[] FPPCMIKIJGN, ushort HCMMKCPLKBO = 0) where T : HIOFLADKOEI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x41EC750", Offset = "0x41EAF50", VA = "0x1841EC750")]
		public static HNFHMBFMBKC FindClosestDefaultUpdateLod(float JOACNJOKIPE)
		{
			return default(HNFHMBFMBKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x41ECB00", Offset = "0x41EB300", VA = "0x1841ECB00")]
		public static HNFHMBFMBKC MinUpdateLod(HNFHMBFMBKC IMLIGIKKAKE, HNFHMBFMBKC LJJHDFDJJFO)
		{
			return default(HNFHMBFMBKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x41ECAA0", Offset = "0x41EB2A0", VA = "0x1841ECAA0")]
		public static HNFHMBFMBKC MaxUpdateLod(HNFHMBFMBKC IMLIGIKKAKE, HNFHMBFMBKC LJJHDFDJJFO)
		{
			return default(HNFHMBFMBKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41ED2B0", Offset = "0x41EBAB0", VA = "0x1841ED2B0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PINMOMNKPHL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IBKDJMFLJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera OPMEPFKDHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DAPLAJJDDGM DLJMPNAIIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NDHOFGKEACC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	DAPLAJJDDGM OPMMGJFKGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform NABBMKLMNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IGDKDJNIGJL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int JFFGDPDIDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int LHJNCHNNCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DNPJBDDGHII<T> : IGDKDJNIGJL where T : HIOFLADKOEI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNFHMBFMBKC HPBECHJPNCC(float LCKAAHNJMCH);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLKJJINIDJF(T DEGGOOGCHFA, float LOBHAECCNKO, GCKCPJOKLLJ HJPFMGBDNKP = GCKCPJOKLLJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLKJJINIDJF(T DEGGOOGCHFA, Transform FKAGOJKLCIM, float LOBHAECCNKO, GCKCPJOKLLJ HJPFMGBDNKP = GCKCPJOKLLJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIOBEMCJLJM(T DEGGOOGCHFA, [Optional] float? LOBHAECCNKO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NHIAFFMKOAF(T NKHFENAOJGE);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HNFHMBFMBKC JIDKOGILIEJ(T DEGGOOGCHFA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OPMBNFJHKNC(T DEGGOOGCHFA);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NABEINHAABM(T DEGGOOGCHFA, GCKCPJOKLLJ KICLNJNNOGD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HIOFLADKOEI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform EOBPGPELLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(HNFHMBFMBKC NGFMNPDBNHI, HNFHMBFMBKC JODKAMELPAM);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool JOKNFGOKHBB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum GCKCPJOKLLJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HNFHMBFMBKC
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
public class AACIFAJAGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HNFHMBFMBKC NFMJKCMCOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private HNFHMBFMBKC AHIONLKAMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, HNFHMBFMBKC> KNANCMHENGA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BIGPDJPEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x41EC520", Offset = "0x41EAD20", VA = "0x1841EC520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public HNFHMBFMBKC GJEEIJPCEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0")]
		get
		{
			return default(HNFHMBFMBKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public HNFHMBFMBKC DHDMFAHHBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6866E0", Offset = "0x684EE0", VA = "0x1806866E0")]
		get
		{
			return default(HNFHMBFMBKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x41EC4B0", Offset = "0x41EACB0", VA = "0x1841EC4B0")]
	public bool HDHHHNOANJM(object HMOHICKINOJ, HNFHMBFMBKC CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41EC570", Offset = "0x41EAD70", VA = "0x1841EC570")]
	public bool OCGOEKCFMJN(object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x41EC340", Offset = "0x41EAB40", VA = "0x1841EC340")]
	private bool GNIBNOGFHIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x41EC5D0", Offset = "0x41EADD0", VA = "0x1841EC5D0")]
	public AACIFAJAGGK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x41ED3A0", Offset = "0x41EBBA0", VA = "0x1841ED3A0")]
	private static string HDJAHDEMDDI(byte[] FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x41ED4A0", Offset = "0x41EBCA0", VA = "0x1841ED4A0")]
	public static string OMJPKAOBENG(byte[] FCDIIMLAMIO, bool PCFPPGPONLG)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
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

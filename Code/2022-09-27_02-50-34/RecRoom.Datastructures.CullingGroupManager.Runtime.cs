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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, EGHAAFLIMGB
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class BFDPJEKLJJL : IDisposable, JLJLJPIEKEA
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int ENBHEMDCEKF
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int JPNMALOGPHK
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
			public abstract void FDNBJIHMMMI();

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void KOKCIMIPPPI(bool AAIEOMLBPGK);

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			protected BFDPJEKLJJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class INPBMHKAFGN<T> : BFDPJEKLJJL, global::ILJBCDGGOAM<T>, JLJLJPIEKEA where T : ALOKADDHHBI
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum DJAOJEFJCFH : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class EEFBHKCGJAN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T ADOBJOBPANG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public CCEBLMGGJFJ LAEDKMKPNHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action MBPGJENOEDN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool NLNOEKJFBHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int CCIFACONDAF;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
				public EEFBHKCGJAN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class APEIGOGMKNP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public INPBMHKAFGN<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public EEFBHKCGJAN trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
				public APEIGOGMKNP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int FICJDLBHKAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int KIMOCDBAOJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int LJJGEKPHHNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool ODHDMLLLNOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup LLFFNGLPIAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] AMJBFDKBFNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] NAILBCJDPPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly GPJAFJDIABD FEPEKJBDLDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> CNMAFBPOJHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, EEFBHKCGJAN> DCHGMJCBMHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly DJAOJEFJCFH OCKKOHPJFNB;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int ENBHEMDCEKF
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int JPNMALOGPHK
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x7CC210", Offset = "0x7CB410", VA = "0x1807CC210", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3A1E540", Offset = "0x3A1D740", VA = "0x183A1E540")]
			internal INPBMHKAFGN(int KIMOCDBAOJA, float[] HHNEKEBAFPF, DJAOJEFJCFH OCKKOHPJFNB = DJAOJEFJCFH.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3A1DC80", Offset = "0x3A1CE80", VA = "0x183A1DC80", Slot = "11")]
			public override void KOKCIMIPPPI(bool AAIEOMLBPGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D2B0", Offset = "0x3A1C4B0", VA = "0x183A1D2B0", Slot = "12")]
			public CLECHKDLIJE GNLCHCMFBGM(float BMCFFNBAMJN)
			{
				return default(CLECHKDLIJE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D740", Offset = "0x3A1C940", VA = "0x183A1D740", Slot = "13")]
			public void KAGEPJABGKM(T PBKPNJLDBOM, float LNOJNMGCCCF, CCEBLMGGJFJ FAJKBCNIGFA = CCEBLMGGJFJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D7E0", Offset = "0x3A1C9E0", VA = "0x183A1D7E0", Slot = "14")]
			public void KAGEPJABGKM(T PBKPNJLDBOM, Transform HIHDJCDGDPB, float LNOJNMGCCCF, CCEBLMGGJFJ FAJKBCNIGFA = CCEBLMGGJFJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D000", Offset = "0x3A1C200", VA = "0x183A1D000", Slot = "8")]
			public override void FDNBJIHMMMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3A1CE70", Offset = "0x3A1C070", VA = "0x183A1CE70", Slot = "15")]
			public void EKPIABMPIKG(T PBKPNJLDBOM, [Optional] float? LNOJNMGCCCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3A1E0A0", Offset = "0x3A1D2A0", VA = "0x183A1E0A0")]
			private void MDJKBINDCHA(int MJNAIOAAGCG, [Optional] float? LNOJNMGCCCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3A1C750", Offset = "0x3A1B950", VA = "0x183A1C750", Slot = "16")]
			public void CEDMIKNCMLN(T KOBDLHKNNOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D620", Offset = "0x3A1C820", VA = "0x183A1D620", Slot = "17")]
			public CLECHKDLIJE JADGDLFKJFF(T PBKPNJLDBOM)
			{
				return default(CLECHKDLIJE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D1B0", Offset = "0x3A1C3B0", VA = "0x183A1D1B0", Slot = "18")]
			public bool GDLPOEEMOAG(T PBKPNJLDBOM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3A1CEF0", Offset = "0x3A1C0F0", VA = "0x183A1CEF0", Slot = "19")]
			public void FDDFOAHACPL(T PBKPNJLDBOM, CCEBLMGGJFJ FJINFFNPBDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3A1CAF0", Offset = "0x3A1BCF0", VA = "0x183A1CAF0", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3A1DCB0", Offset = "0x3A1CEB0", VA = "0x183A1DCB0")]
			private void LGLEMGDKBAO(EEFBHKCGJAN LAEBNDCDLIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3A1E2C0", Offset = "0x3A1D4C0", VA = "0x183A1E2C0")]
			private void PCEEDBAILAM(EEFBHKCGJAN LAEBNDCDLIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3A1E250", Offset = "0x3A1D450", VA = "0x183A1E250")]
			private void PAIHDGAOIEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3A1E1E0", Offset = "0x3A1D3E0", VA = "0x183A1E1E0")]
			private void MIMLMEKOFFD(float FBMDAMODNPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3A1E060", Offset = "0x3A1D260", VA = "0x183A1E060")]
			private void LJINAPCIAHF(EEFBHKCGJAN LAEBNDCDLIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3A1DC60", Offset = "0x3A1CE60", VA = "0x183A1DC60")]
			private void KGNKLLLLAAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D180", Offset = "0x3A1C380", VA = "0x183A1D180")]
			private void FOJABFCONIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D310", Offset = "0x3A1C510", VA = "0x183A1D310")]
			private void IOAAGIGGNAN(CullingGroupEvent HIHEAEGBIBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x3A1C5E0", Offset = "0x3A1B7E0", VA = "0x183A1C5E0")]
			private void AHCIJJGLPFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct DPLLGCBOKDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort KJBMOAENKMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type ELGLIGPOHEJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float GOMHEENKHKK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float KOJKBHPPJNO = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IMGOPIADEEJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GMJPOMOHAJI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float OLPGOMACAIH = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float ONHIJMKEJAK = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float MHPOBONLION = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<DPLLGCBOKDA, BFDPJEKLJJL> PDPKDHGGCDE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable JDCIJHKOPDG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FFKCALKFOIK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static EOAHAKPACKC PBEBONLFIGD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EOAHAKPACKC GCJDDFEHNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly EOAHAKPACKC DIFHLGJPBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EOAHAKPACKC MHLFMANDEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EOAHAKPACKC ICACPJHDECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NNDKFCLIIOJ LEHNOBOIEME;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool AAIEOMLBPGK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EOAHAKPACKC OFPBHGJHIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EOAHAKPACKC LKMHKPFFIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EOAHAKPACKC DIIBDCPLLGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x622F40", Offset = "0x622140", VA = "0x180622F40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DOLGHDEKIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x2874760", Offset = "0x2873960", VA = "0x182874760", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JLIDILDBEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x94F170", Offset = "0x94E370", VA = "0x18094F170", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x94F660", Offset = "0x94E860", VA = "0x18094F660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2873A10", Offset = "0x2872C10", VA = "0x182873A10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x22636B0", Offset = "0x22628B0", VA = "0x1822636B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2874170", Offset = "0x2873370", VA = "0x182874170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2873E00", Offset = "0x2873000", VA = "0x182873E00")]
		private void GCELIPMJIAJ(Scene EHOKFNHPHEI, LoadSceneMode PCDNKMPEHGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28740C0", Offset = "0x28732C0", VA = "0x1828740C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28743F0", Offset = "0x28735F0", VA = "0x1828743F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2873E60", Offset = "0x2873060", VA = "0x182873E60")]
		private void HNCNJECGPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2874190", Offset = "0x2873390", VA = "0x182874190")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2873AB0", Offset = "0x2872CB0", VA = "0x182873AB0")]
		private void DPKLIHHIKNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3989340", Offset = "0x3988540", VA = "0x183989340")]
		public global::ILJBCDGGOAM<T> GetOrCreateCullingGroup<T>(int EDOOCAHDDFD, ushort OJPHEKLIPOB = 0) where T : ALOKADDHHBI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3989130", Offset = "0x3988330", VA = "0x183989130")]
		private global::ILJBCDGGOAM<T> BFEDGCFCAEP<T>(int EDOOCAHDDFD, float[] HHNEKEBAFPF, ushort OJPHEKLIPOB = 0) where T : ALOKADDHHBI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2873C10", Offset = "0x2872E10", VA = "0x182873C10")]
		public static CLECHKDLIJE FindClosestDefaultUpdateLod(float KFEPLIKDMFM)
		{
			return default(CLECHKDLIJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2874060", Offset = "0x2873260", VA = "0x182874060")]
		public static CLECHKDLIJE MinUpdateLod(CLECHKDLIJE ILINPHKLNEG, CLECHKDLIJE IACHDPHNNAG)
		{
			return default(CLECHKDLIJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2874000", Offset = "0x2873200", VA = "0x182874000")]
		public static CLECHKDLIJE MaxUpdateLod(CLECHKDLIJE ILINPHKLNEG, CLECHKDLIJE IACHDPHNNAG)
		{
			return default(CLECHKDLIJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2874670", Offset = "0x2873870", VA = "0x182874670")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GPJAFJDIABD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LNIDBFHDKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera HDINCNIANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EOAHAKPACKC LFLJNAOEEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MKLIGOONJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EOAHAKPACKC EHAGNMCKNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform GPONFKGGDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JLJLJPIEKEA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int ENBHEMDCEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int JPNMALOGPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ILJBCDGGOAM<T> : JLJLJPIEKEA where T : ALOKADDHHBI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLECHKDLIJE GNLCHCMFBGM(float BMCFFNBAMJN);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAGEPJABGKM(T PBKPNJLDBOM, float LNOJNMGCCCF, CCEBLMGGJFJ FAJKBCNIGFA = CCEBLMGGJFJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAGEPJABGKM(T PBKPNJLDBOM, Transform HIHDJCDGDPB, float LNOJNMGCCCF, CCEBLMGGJFJ FAJKBCNIGFA = CCEBLMGGJFJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EKPIABMPIKG(T PBKPNJLDBOM, [Optional] float? LNOJNMGCCCF);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CEDMIKNCMLN(T KOBDLHKNNOD);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CLECHKDLIJE JADGDLFKJFF(T PBKPNJLDBOM);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GDLPOEEMOAG(T PBKPNJLDBOM);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FDDFOAHACPL(T PBKPNJLDBOM, CCEBLMGGJFJ AEGLFCCOKNK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ALOKADDHHBI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform EJOKPJGAPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CLECHKDLIJE CDNPLFBFMKI, CLECHKDLIJE HMAEKDDEJGE);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EJIPFEIEKPI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum CCEBLMGGJFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CLECHKDLIJE
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
public class HOOFKPBNBNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private CLECHKDLIJE CKOAFJABJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private CLECHKDLIJE ONDKPLDODAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, CLECHKDLIJE> IGMKLAGBBHM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool IMKLGJHDGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28747D0", Offset = "0x28739D0", VA = "0x1828747D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public CLECHKDLIJE HIFKHKCHLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62D550", Offset = "0x62C750", VA = "0x18062D550")]
		get
		{
			return default(CLECHKDLIJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CLECHKDLIJE EFFIMACHDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC210", Offset = "0x7CB410", VA = "0x1807CC210")]
		get
		{
			return default(CLECHKDLIJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2874990", Offset = "0x2873B90", VA = "0x182874990")]
	public bool NLOPPMNLCMA(object HCPCDENCJBA, CLECHKDLIJE ADBNEBBHMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2874770", Offset = "0x2873970", VA = "0x182874770")]
	public bool HPPOBMDBMOI(object HCPCDENCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2874820", Offset = "0x2873A20", VA = "0x182874820")]
	private bool JBOJMJJKHHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2874A00", Offset = "0x2873C00", VA = "0x182874A00")]
	public HOOFKPBNBNA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class INAFFMAFPID
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] JIMOKIHBHOH;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int FMDPFNLECKI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int AONCPEEEHKG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger ILKJFGLFAMB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
	public INAFFMAFPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2874DB0", Offset = "0x2873FB0", VA = "0x182874DB0")]
	private static string JBPNMHMEPIE(byte[] KLGGEDCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2874A80", Offset = "0x2873C80", VA = "0x182874A80")]
	public static string HDPEGNHHKLG(byte[] FAOJAOEJLMO, bool CGIGAMOFOGM)
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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
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

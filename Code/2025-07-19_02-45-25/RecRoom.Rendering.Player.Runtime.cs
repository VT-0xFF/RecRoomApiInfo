using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89B52F0", Offset = "0x89B42F0", VA = "0x1889B52F0", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8334620", Offset = "0x8333620", VA = "0x188334620", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89B5400", Offset = "0x89B4400", VA = "0x1889B5400")]
		private void MNKCLNFPDFM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89B5880", Offset = "0x89B4880", VA = "0x1889B5880", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89B5650", Offset = "0x89B4650", VA = "0x1889B5650", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89B58E0", Offset = "0x89B48E0", VA = "0x1889B58E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GPHLBOJMLBC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int? ALKHOBMMJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool? POGGAPKBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GOBMAIODFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLIOMNFJODA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FEEBDFILOFB : GPHLBOJMLBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly string DCILKEFJGFL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly string DKGOAPAPDGG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly string HNHGOMMOEFI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly string EGCIOHGODJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MCIAFEMJFEE MMEIIKFIDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int? GOPMKFIJIDC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int? ALKHOBMMJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GOBMAIODFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool? POGGAPKBCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89B3180", Offset = "0x89B2180", VA = "0x1889B3180", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	[UnityEngine.Scripting.Preserve]
	public FEEBDFILOFB([KELEGLJPNHI(null)][NotNull] MCIAFEMJFEE FEOBKHBKLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x89B3010", Offset = "0x89B2010", VA = "0x1889B3010", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x89B3110", Offset = "0x89B2110", VA = "0x1889B3110")]
	[GOMLKAICHII.JENKOCGKLOO.LCLJJMFJJCN]
	[UsedImplicitly]
	public static void HBGDJDKKNIO(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x89B37A0", Offset = "0x89B27A0", VA = "0x1889B37A0", Slot = "5")]
	public void PLIOMNFJODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x89B31D0", Offset = "0x89B21D0", VA = "0x1889B31D0")]
	private void MCMELNHNKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x89B2F30", Offset = "0x89B1F30", VA = "0x1889B2F30")]
	private bool BMJJCIIDDJI(string AFHKABCHFHH, [Out] JOGKCIKLCEK FBHAACOPLAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IBNBBPHMCML
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDNACMPJANA();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KDFBPILPFFH : IBNBBPHMCML
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JCEOGMKOCBI : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KDFBPILPFFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public JCEOGMKOCBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x89B3A30", Offset = "0x89B2A30", VA = "0x1889B3A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89B3B20", Offset = "0x89B2B20", VA = "0x1889B3B20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HHGNPNNJJPG JOKIMEMNHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int AFIJMOGFJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool? KMLMPGOGNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool DGDBEOOEFMN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static ONIHMLNNEEF NDOPOKDOPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<string> JKPOAANCBPH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x89B4370", Offset = "0x89B3370", VA = "0x1889B4370")]
	[UnityEngine.Scripting.Preserve]
	public KDFBPILPFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x89B3B70", Offset = "0x89B2B70", VA = "0x1889B3B70")]
	private HHGNPNNJJPG DJGNBKFLHHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x89B3C80", Offset = "0x89B2C80", VA = "0x1889B3C80")]
	[IteratorStateMachine(typeof(JCEOGMKOCBI))]
	private IEnumerator<CMMCHACHDBH> DNALELENGOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x89B3D70", Offset = "0x89B2D70", VA = "0x1889B3D70")]
	private void MFNGHHNPIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x89B3D00", Offset = "0x89B2D00", VA = "0x1889B3D00")]
	[GOMLKAICHII.NIENCEEHOCF]
	public static void HBGDJDKKNIO(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x89B4160", Offset = "0x89B3160", VA = "0x1889B4160", Slot = "4")]
	public void NDNACMPJANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(LPAKHCMEJOI), new string[] { })]
public class LPAKHCMEJOI : FOONNKPJAPP, MEIFILLJDCJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class AFJHLEHJOKP : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LPAKHCMEJOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public AFJHLEHJOKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89B2CC0", Offset = "0x89B1CC0", VA = "0x1889B2CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89B2EE0", Offset = "0x89B1EE0", VA = "0x1889B2EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GPHLBOJMLBC EKKOGMFNIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private DDAPLCBMGDI IPEHDPLJIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDisposable PLPODGKELPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IDisposable ENHIHJDICFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HashSet<ReflectionProbe> HDEOOICNGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool ICGAIDOHNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private bool PFCKJBFNEGA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x89B5260", Offset = "0x89B4260", VA = "0x1889B5260")]
	[UnityEngine.Scripting.Preserve]
	public LPAKHCMEJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x89B4D30", Offset = "0x89B3D30", VA = "0x1889B4D30", Slot = "4")]
	public void InitExternal(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x89B4A90", Offset = "0x89B3A90", VA = "0x1889B4A90")]
	private void CKHCCLHMPPN(Scene FHJEFMKKECN, LoadSceneMode NLKIMELACNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x89B4AA0", Offset = "0x89B3AA0", VA = "0x1889B4AA0")]
	private void EGEPCBKDOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x89B4C50", Offset = "0x89B3C50", VA = "0x1889B4C50")]
	private void GLBBECEAJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x89B4EE0", Offset = "0x89B3EE0", VA = "0x1889B4EE0")]
	private (ReflectionProbe, int) PKIAHCDIKAI()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x89B4490", Offset = "0x89B3490", VA = "0x1889B4490")]
	[IteratorStateMachine(typeof(AFJHLEHJOKP))]
	private IEnumerator<CMMCHACHDBH> ACACPMODOJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x89B4510", Offset = "0x89B3510", VA = "0x1889B4510")]
	private void CDHMBPIPBFM([CanBeNull] ReflectionProbe FJKLJGPPCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x89B4EB0", Offset = "0x89B3EB0", VA = "0x1889B4EB0")]
	private void MGCKCLKHJJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x89B5180", Offset = "0x89B4180", VA = "0x1889B5180")]
	private void POIFAKPENBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x89B50A0", Offset = "0x89B40A0", VA = "0x1889B50A0", Slot = "5")]
	public void PMFJBDENDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x89B45F0", Offset = "0x89B35F0", VA = "0x1889B45F0")]
	[CompilerGenerated]
	private void CFILLBJNECH()
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

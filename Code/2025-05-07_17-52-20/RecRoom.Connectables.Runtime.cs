using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A280", Offset = "0x7B89280", VA = "0x187B8A280", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
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
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B94F80", Offset = "0x7B93F80", VA = "0x187B94F80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B94AE0", Offset = "0x7B93AE0", VA = "0x187B94AE0")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B94970", Offset = "0x7B93970", VA = "0x187B94970")]
		private void KMFPJCIAGGA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B94C50", Offset = "0x7B93C50", VA = "0x187B94C50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B94FC0", Offset = "0x7B93FC0", VA = "0x187B94FC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class PBBABANPFCD : HAEKELLPJAC, MMMIGLKPHHG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BGEODJEJKLG : IEnumerable<KGJNPMKJIIA>, IEnumerable, IEnumerator<KGJNPMKJIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KGJNPMKJIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private PKENAFNLEAO localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PKENAFNLEAO <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PBBABANPFCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JFDGJOPOGFB <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private EPFJFEANHAG <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private EPFJFEANHAG.MJEICEPECDM <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KGJNPMKJIIA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public BGEODJEJKLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B80150", Offset = "0x7B7F150", VA = "0x187B80150", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B7FCD0", Offset = "0x7B7ECD0", VA = "0x187B7FCD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B7FCB0", Offset = "0x7B7ECB0", VA = "0x187B7FCB0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B80030", Offset = "0x7B7F030", VA = "0x187B80030")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B80100", Offset = "0x7B7F100", VA = "0x187B80100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B80050", Offset = "0x7B7F050", VA = "0x187B80050", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KGJNPMKJIIA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B80050", Offset = "0x7B7F050", VA = "0x187B80050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ODFHNMNNIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PBBABANPFCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public FHKJOHOMFCJ nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ODFHNMNNIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E060", Offset = "0x7B8D060", VA = "0x187B8E060")]
		internal object LKBIBKEPLCM(FHKJOHOMFCJ x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MLBJINNFDAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FHKJOHOMFCJ child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ODFHNMNNIKE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MLBJINNFDAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A4D0", Offset = "0x7B894D0", VA = "0x187B8A4D0")]
		internal object LGNIJGGBMBM((FHKJOHOMFCJ child, FHKJOHOMFCJ nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly JBBHIJHGEPM GGJADJBPBEE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly JBBHIJHGEPM DNCEFGKMPLO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly JBBHIJHGEPM BJAJIFOAHGO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly JBBHIJHGEPM NEAMJIMPKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private KLJACPCBIBJ GLLCNGPPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MIJCBDFLLCM EBBCJEKFBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private JHOFBNJCHGN GJDOLECHAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HMHGMBFLDMI DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private OIAIGLOONMN HLKPCNLNBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PLCKOGMOKKF BHBOGOEHMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ALAAAJBIMIM IDEMOBALCHO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9FACA0", Offset = "0x9F9CA0", VA = "0x1809FACA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9FAC90", Offset = "0x9F9C90", VA = "0x1809FAC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LEKOKFJOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F790", Offset = "0x7B8E790", VA = "0x187B8F790", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B910D0", Offset = "0x7B900D0", VA = "0x187B910D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B90620", Offset = "0x7B8F620", VA = "0x187B90620", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B92540", Offset = "0x7B91540", VA = "0x187B92540", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B90850", Offset = "0x7B8F850", VA = "0x187B90850", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B925F0", Offset = "0x7B915F0", VA = "0x187B925F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7B941E0", Offset = "0x7B931E0", VA = "0x187B941E0")]
	public PBBABANPFCD(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B8FDF0", Offset = "0x7B8EDF0", VA = "0x187B8FDF0", Slot = "12")]
	public void ANJKPBDKBKO(GameObject CEKGANCAJPA, GMDBFGIIFFC GHDIGEKIHBA, EGONKLCENLD OHEIAKHGGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B92730", Offset = "0x7B91730", VA = "0x187B92730", Slot = "26")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B934E0", Offset = "0x7B924E0", VA = "0x187B934E0", Slot = "22")]
	public bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B91590", Offset = "0x7B90590", VA = "0x187B91590")]
	private void JCOEKOAFMEA(PKENAFNLEAO ILCDACLHNOJ, PKENAFNLEAO ONKEPDCFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B922B0", Offset = "0x7B912B0", VA = "0x187B922B0")]
	private void MDJDLJABCJB(PKENAFNLEAO ILCDACLHNOJ, PKENAFNLEAO NAFICNAJMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B93A00", Offset = "0x7B92A00", VA = "0x187B93A00")]
	private void PHMNFBNNEAF(PKENAFNLEAO ILCDACLHNOJ, PKENAFNLEAO NAFICNAJMHL, PKENAFNLEAO ONKEPDCFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B93C60", Offset = "0x7B92C60", VA = "0x187B93C60")]
	private void PIFLPHIAEMB(PKENAFNLEAO ILCDACLHNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "13")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B8FAE0", Offset = "0x7B8EAE0", VA = "0x187B8FAE0", Slot = "14")]
	public void AMBIAOGNIIF(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "15")]
	public void OMFPKPKPLOB(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B904C0", Offset = "0x7B8F4C0", VA = "0x187B904C0", Slot = "17")]
	public void CHFGABCDLEC(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA NJNFNFBFADF, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B90380", Offset = "0x7B8F380", VA = "0x187B90380")]
	public void CHFGABCDLEC(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO NJNFNFBFADF, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B90A90", Offset = "0x7B8FA90", VA = "0x187B90A90")]
	public void EOOOLAKNNAP(KGJNPMKJIIA OAECINPEBBO, float MJAHKCHDPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F980", Offset = "0x7B8E980", VA = "0x187B8F980", Slot = "18")]
	public void AKAEAHNKFMK(KGJNPMKJIIA HEKGNKKHMND, int GOPHADGGKNM, KGJNPMKJIIA HKFAMNCINCG, int NBNILDCJONJ, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B91020", Offset = "0x7B90020", VA = "0x187B91020")]
	private float HPCJBOBOGAN(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO JHDAOHEONAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F840", Offset = "0x7B8E840", VA = "0x187B8F840")]
	public void AKAEAHNKFMK(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO JHDAOHEONAC, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, bool HDBFKADDDEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B917A0", Offset = "0x7B907A0", VA = "0x187B917A0", Slot = "19")]
	public void JJEPLKJECKD(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B92920", Offset = "0x7B91920", VA = "0x187B92920", Slot = "16")]
	public void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> FMCCIABOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "20")]
	public JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "21")]
	public JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B92240", Offset = "0x7B91240", VA = "0x187B92240", Slot = "23")]
	public void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B924D0", Offset = "0x7B914D0", VA = "0x187B924D0", Slot = "24")]
	public void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B90080", Offset = "0x7B8F080", VA = "0x187B90080", Slot = "25")]
	public void BDHOBHEBPMH(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B92B30", Offset = "0x7B91B30", VA = "0x187B92B30")]
	private void NJNHIAMMBKP(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO JHDAOHEONAC, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, float MJAHKCHDPBO, bool HDBFKADDDEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B91910", Offset = "0x7B90910", VA = "0x187B91910")]
	private void JNICNGKBIJI(PKENAFNLEAO HMCFPGIFOED, PKENAFNLEAO FAMAONKAFDI, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B906D0", Offset = "0x7B8F6D0", VA = "0x187B906D0")]
	private void DGIFILGEKAD(PKENAFNLEAO HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B926A0", Offset = "0x7B916A0", VA = "0x187B926A0")]
	[IteratorStateMachine(typeof(BGEODJEJKLG))]
	public IEnumerable<KGJNPMKJIIA> NBEPPKKEEPI(PKENAFNLEAO GOGGPBKDKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B93530", Offset = "0x7B92530", VA = "0x187B93530")]
	internal KGJNPMKJIIA OPMKLMMJJEG(PKENAFNLEAO GOGGPBKDKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B90900", Offset = "0x7B8F900", VA = "0x187B90900")]
	internal PKENAFNLEAO EIOCNHFCNCF(KGJNPMKJIIA OAECINPEBBO)
	{
		return default(PKENAFNLEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B92F40", Offset = "0x7B91F40", VA = "0x187B92F40")]
	private bool ODGHMKJPKDN(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F730", Offset = "0x7B8E730", VA = "0x187B8F730")]
	private bool AAMNJLNJDPA(FHKJOHOMFCJ MECICAJOHBD, [Out] KGJNPMKJIIA JHDAOHEONAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B93660", Offset = "0x7B92660", VA = "0x187B93660")]
	private KGJNPMKJIIA OPMKLMMJJEG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B90E90", Offset = "0x7B8FE90", VA = "0x187B90E90")]
	private KGJNPMKJIIA FPBMJJIAKCI(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B90CB0", Offset = "0x7B8FCB0", VA = "0x187B90CB0")]
	private KGJNPMKJIIA FNAMBHGNBPO(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B86EE0", Offset = "0x7B85EE0", VA = "0x187B86EE0")]
	private static Guid LOELKJPBEAO(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B90290", Offset = "0x7B8F290", VA = "0x187B90290")]
	private string CCODCGDKILB(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B91400", Offset = "0x7B90400", VA = "0x187B91400")]
	private void JAAGLKJFNJO(KGJNPMKJIIA HMCFPGIFOED, KGJNPMKJIIA FAMAONKAFDI, RigidTransform LGKMMMDABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B90100", Offset = "0x7B8F100", VA = "0x187B90100")]
	private void CBABJCPBPHD(KGJNPMKJIIA FAMAONKAFDI, KGJNPMKJIIA HMCFPGIFOED, RigidTransform LGKMMMDABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B900A0", Offset = "0x7B8F0A0", VA = "0x187B900A0")]
	private void BDPJJDCEPMM(KGJNPMKJIIA FKDPBFFLHKA, KGJNPMKJIIA HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B90B20", Offset = "0x7B8FB20", VA = "0x187B90B20")]
	private void FBJHHBCMKAH(KGJNPMKJIIA HMCFPGIFOED, KGJNPMKJIIA JHDAOHEONAC, RigidTransform LGKMMMDABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B90740", Offset = "0x7B8F740", VA = "0x187B90740")]
	private void DLBEDLCFLHC(PKENAFNLEAO GOGGPBKDKBC, KGJNPMKJIIA OAECINPEBBO, PKENAFNLEAO NAFICNAJMHL, PKENAFNLEAO ONKEPDCFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B91180", Offset = "0x7B90180", VA = "0x187B91180")]
	private void INELCBADLIG(PKENAFNLEAO GOGGPBKDKBC, KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA ANIIDMDIGEL, KGJNPMKJIIA CKMMPPDMABF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NPKPPLHNIDB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MAJBDMLKIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AINJBKKEAIL container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MAJBDMLKIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A420", Offset = "0x7B89420", VA = "0x187B8A420")]
		internal PBBABANPFCD GALEJCAFIPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DE90", Offset = "0x7B8CE90", VA = "0x187B8DE90")]
	public static void KCIDEFBNJAG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E010", Offset = "0x7B8D010", VA = "0x187B8E010")]
	public static void KFBNFICJJPH(AINJBKKEAIL NELIKBMJKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FOBPKODMDJG : KLOADKCPJHM, NALCGEOCDAO
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly PBBABANPFCD AGINJBNDJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HJHBCOKCHDP BLHGDGOHGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AHEJCECPAPD DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly OLOLIIEIDMJ[] BEDIEIBMOAJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KGJNPMKJIIA DIKCMBOKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B84A60", Offset = "0x7B83A60", VA = "0x187B84A60", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KGJNPMKJIIA IKAHKCFCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B84520", Offset = "0x7B83520", VA = "0x187B84520", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 DLCDCKGOJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7B835F0", Offset = "0x7B825F0", VA = "0x187B835F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion HELDODPPOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B845E0", Offset = "0x7B835E0", VA = "0x187B845E0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool ILPDIFJOOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B83800", Offset = "0x7B82800", VA = "0x187B83800", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<KGJNPMKJIIA> AOODDHOINDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B84040", Offset = "0x7B83040", VA = "0x187B84040", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool MJJEAGMAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC118F0", Offset = "0xC108F0", VA = "0x180C118F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC17A10", Offset = "0xC16A10", VA = "0x180C17A10", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B84C70", Offset = "0x7B83C70", VA = "0x187B84C70", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject ACLMMAOCLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7B84970", Offset = "0x7B83970", VA = "0x187B84970", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7B84990", Offset = "0x7B83990", VA = "0x187B84990", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid DAKAIKDKNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7B84AC0", Offset = "0x7B83AC0", VA = "0x187B84AC0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HLCFDICAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B84BA0", Offset = "0x7B83BA0", VA = "0x187B84BA0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DOAKLKNBOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool KMMJMFIFKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7B83540", Offset = "0x7B82540", VA = "0x187B83540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NIGKAAIBONN GDBKOPGIMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B844C0", Offset = "0x7B834C0", VA = "0x187B844C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B83590", Offset = "0x7B82590", VA = "0x187B83590", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NIGKAAIBONN COPNMFMFJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B837A0", Offset = "0x7B827A0", VA = "0x187B837A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B83DD0", Offset = "0x7B82DD0", VA = "0x187B83DD0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NIGKAAIBONN CLBOCEOOAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7B846C0", Offset = "0x7B836C0", VA = "0x187B846C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7B83740", Offset = "0x7B82740", VA = "0x187B83740", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event FBEGKNIFEEB LBKLFLHJGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B84350", Offset = "0x7B83350", VA = "0x187B84350", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B84720", Offset = "0x7B83720", VA = "0x187B84720", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B84870", Offset = "0x7B83870", VA = "0x187B84870")]
	public FOBPKODMDJG(PKENAFNLEAO DCOBGODCAEM, RigidbodyEx DPBHNMFBAMI, HJHBCOKCHDP BLHGDGOHGFH, OLOLIIEIDMJ[] BEDIEIBMOAJ, AHEJCECPAPD DHJEDIPMPLO, HAEKELLPJAC AGINJBNDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B84640", Offset = "0x7B83640", VA = "0x187B84640", Slot = "19")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "21")]
	public void HHHNHJPFGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x78DF2E0", Offset = "0x78DE2E0", VA = "0x1878DF2E0", Slot = "22")]
	public void CNLGGHFAMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B843F0", Offset = "0x7B833F0", VA = "0x187B843F0", Slot = "20")]
	public void JDIKNMDACEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B83E30", Offset = "0x7B82E30", VA = "0x187B83E30", Slot = "25")]
	public void IGIHFOHFFKB(int DCKHPKBNAHB, KGJNPMKJIIA HKFAMNCINCG, int JFAHNBMPGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B82E60", Offset = "0x7B81E60", VA = "0x187B82E60", Slot = "26")]
	public void ACMIJCNLBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7B84070", Offset = "0x7B83070", VA = "0x187B84070", Slot = "27")]
	public void INIADDEOGCK(int DCKHPKBNAHB, KGJNPMKJIIA HEKGNKKHMND, int GHHMMIAAMBI, [Optional] Vector3? FDLKFNIKBIK, [Optional] Quaternion? EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B84440", Offset = "0x7B83440", VA = "0x187B84440", Slot = "28")]
	public void JEFNMAOFAPJ(KGJNPMKJIIA HEKGNKKHMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B82F30", Offset = "0x7B81F30", VA = "0x187B82F30", Slot = "31")]
	public void BBLMKFMBJEC(Vector3 JGAGMHABFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B83AC0", Offset = "0x7B82AC0", VA = "0x187B83AC0", Slot = "29")]
	public void HEPFHHFIKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B83340", Offset = "0x7B82340", VA = "0x187B83340", Slot = "30")]
	public void BEJJGDDMNPL(int OHHMJGCBCKD, Vector3 HNHGJPFCFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B839F0", Offset = "0x7B829F0", VA = "0x187B839F0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int DCKHPKBNAHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B838C0", Offset = "0x7B828C0", VA = "0x187B838C0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int DCKHPKBNAHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xBEA630", Offset = "0xBE9630", VA = "0x180BEA630", Slot = "42")]
	public Color GetConnectionSlotColor(int DCKHPKBNAHB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B83650", Offset = "0x7B82650", VA = "0x187B83650", Slot = "43")]
	public bool CanConnectTo(int DCKHPKBNAHB, KGJNPMKJIIA PKOBDBDFJDH, int MFGPLFMGPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "44")]
	public void ParentChanged(int DCKHPKBNAHB, KGJNPMKJIIA HLHOBMFDMEH, int OHFINMJADPB, Vector3 MKLDCPIGJAH, Quaternion CKPBCMANCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "45")]
	public void ChildAdded(int DCKHPKBNAHB, KGJNPMKJIIA EFPDNAFKIKI, int KOKLNGICLKB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "46")]
	public void ChildRemoved(int DCKHPKBNAHB, KGJNPMKJIIA GGGJPOKBGDE, int JGFEALFMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "47")]
	public void ConnectionModified(int DCKHPKBNAHB, KGJNPMKJIIA HKFAMNCINCG, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B847C0", Offset = "0x7B837C0", VA = "0x187B847C0", Slot = "48")]
	public void RootChanged(KGJNPMKJIIA IOMLMEIBDMC, KGJNPMKJIIA GMAPFDOKMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B836F0", Offset = "0x7B826F0", VA = "0x187B836F0", Slot = "23")]
	public void DFFIMHGDEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B84670", Offset = "0x7B83670", VA = "0x187B84670", Slot = "24")]
	public void OEHLEAOCAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7B83870", Offset = "0x7B82870", VA = "0x187B83870")]
	private void GJDAKHHOFGC(bool MDLOOCDELDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(CCJNJBAAKAD), new string[] { })]
public class PICAOOPPNAI : CCJNJBAAKAD, KBDPBLKCNPK, FGICIDPFKIB
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BKLGIGJEFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BKLGIGJEFFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private MBIJHFNKOKE JDPKJPILGNF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object COLECDGBHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B945F0", Offset = "0x7B935F0", VA = "0x187B945F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7B94680", Offset = "0x7B93680", VA = "0x187B94680", Slot = "5")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x112CAB0", Offset = "0x112BAB0", VA = "0x18112CAB0", Slot = "6")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PICAOOPPNAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(HAEKELLPJAC), new string[] { "Ignore", "Mock" })]
public class COPFPLINDCF : HAEKELLPJAC, MMMIGLKPHHG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LEKOKFJOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B80370", Offset = "0x7B7F370", VA = "0x187B80370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B80580", Offset = "0x7B7F580", VA = "0x187B80580", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B80420", Offset = "0x7B7F420", VA = "0x187B80420", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B80630", Offset = "0x7B7F630", VA = "0x187B80630", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B804D0", Offset = "0x7B7F4D0", VA = "0x187B804D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B806E0", Offset = "0x7B7F6E0", VA = "0x187B806E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "26")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "12")]
	public void ANJKPBDKBKO(GameObject CEKGANCAJPA, GMDBFGIIFFC GHDIGEKIHBA, EGONKLCENLD FJLMGGKGAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "13")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "14")]
	public void AMBIAOGNIIF(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "15")]
	public void OMFPKPKPLOB(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "16")]
	public void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> FMCCIABOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "17")]
	public void CHFGABCDLEC(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA NJNFNFBFADF, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "18")]
	public void AKAEAHNKFMK(KGJNPMKJIIA OAECINPEBBO, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "19")]
	public void JJEPLKJECKD(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "20")]
	public JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "21")]
	public JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "22")]
	public bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "23")]
	public void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "24")]
	public void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "25")]
	public void BDHOBHEBPMH(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public COPFPLINDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KGJNPMKJIIA : NALCGEOCDAO, IEquatable<KGJNPMKJIIA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NALCGEOCDAO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KGJNPMKJIIA DIKCMBOKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject ACLMMAOCLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid DAKAIKDKNDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HLCFDICAKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DOAKLKNBOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int DCKHPKBNAHB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int DCKHPKBNAHB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int DCKHPKBNAHB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int DCKHPKBNAHB, KGJNPMKJIIA PKOBDBDFJDH, int JLBDCAHEGFC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int DCKHPKBNAHB, KGJNPMKJIIA HLHOBMFDMEH, int OHFINMJADPB, Vector3 MKLDCPIGJAH, Quaternion CKPBCMANCNO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int DCKHPKBNAHB, KGJNPMKJIIA EFPDNAFKIKI, int KOKLNGICLKB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int DCKHPKBNAHB, KGJNPMKJIIA GGGJPOKBGDE, int JGFEALFMLMD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int DCKHPKBNAHB, KGJNPMKJIIA HKFAMNCINCG, int DOLFIDPOHID, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(KGJNPMKJIIA IOMLMEIBDMC, KGJNPMKJIIA GMAPFDOKMHL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HAEKELLPJAC : MMMIGLKPHHG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LEKOKFJOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ANJKPBDKBKO(GameObject CEKGANCAJPA, GMDBFGIIFFC GHDIGEKIHBA, EGONKLCENLD FEDKNCIDEOI);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IEKHBJGOAKB();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMBIAOGNIIF(KGJNPMKJIIA OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OMFPKPKPLOB(KGJNPMKJIIA OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> FMCCIABOIAA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CHFGABCDLEC(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA NJNFNFBFADF, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKAEAHNKFMK(KGJNPMKJIIA OAECINPEBBO, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JJEPLKJECKD(KGJNPMKJIIA OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BDHOBHEBPMH(JLPHBPPDHAI NOKCJFMDPME);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HMHGMBFLDMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KGJNPMKJIIA FNAMBHGNBPO(int EBNHDKCINFK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KGJNPMKJIIA FPBMJJIAKCI(Guid JOEDKMGHBFA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEFNIFKHOPH(KGJNPMKJIIA OAECINPEBBO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OFLFNGHAMAD();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDDKMLAHBPE(KGJNPMKJIIA BLHGDGOHGFH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface AHEJCECPAPD
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMMJMFIFKBB(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNOBEGAKHDK(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string EBMOMOKCHOK(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid FIFDPJDKCDJ(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CFKCDEBMJNN(HJHBCOKCHDP BLHGDGOHGFH);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHKCOPLKLEJ(HJHBCOKCHDP BLHGDGOHGFH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void NIGKAAIBONN(KGJNPMKJIIA HEKGNKKHMND, int BNCAJCFDLHD, KGJNPMKJIIA HKFAMNCINCG, int FCGFLIFKIFK, [Optional] Vector3? FDLKFNIKBIK, [Optional] Quaternion? EABCELBPDPO);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void FBEGKNIFEEB(KGJNPMKJIIA IOMLMEIBDMC, KGJNPMKJIIA GMAPFDOKMHL);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HJHBCOKCHDP : KGJNPMKJIIA, NALCGEOCDAO, IEquatable<KGJNPMKJIIA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KLOADKCPJHM : NALCGEOCDAO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KGJNPMKJIIA IKAHKCFCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<KGJNPMKJIIA> AOODDHOINDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 DLCDCKGOJJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion HELDODPPOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool ILPDIFJOOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MJJEAGMAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event NIGKAAIBONN GDBKOPGIMFE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event NIGKAAIBONN COPNMFMFJEN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NIGKAAIBONN CLBOCEOOAJB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event FBEGKNIFEEB LBKLFLHJGBE;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JDIKNMDACEI();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HHHNHJPFGBH();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CNLGGHFAMOH();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DFFIMHGDEGN();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OEHLEAOCAGI();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IGIHFOHFFKB(int DCKHPKBNAHB, KGJNPMKJIIA HKFAMNCINCG, int JFAHNBMPGPB);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ACMIJCNLBEF();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void INIADDEOGCK(int DCKHPKBNAHB, KGJNPMKJIIA HEKGNKKHMND, int GHHMMIAAMBI, [Optional] Vector3? FDLKFNIKBIK, [Optional] Quaternion? EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JEFNMAOFAPJ(KGJNPMKJIIA HEKGNKKHMND);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HEPFHHFIKGG();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BEJJGDDMNPL(int OHHMJGCBCKD, Vector3 HNHGJPFCFDL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BBLMKFMBJEC(Vector3 JGAGMHABFEO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OLOLIIEIDMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 GNFKNNGOKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GMDBFGIIFFC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KILMCEKGICN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	GCHDFMGBKEJ HJEFIMHLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, GMDBFGIIFFC
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public GCHDFMGBKEJ LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B80790", Offset = "0x7B7F790", VA = "0x187B80790")]
		public static ConnectableConfigData KIGBJCOFDAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B80850", Offset = "0x7B7F850", VA = "0x187B80850")]
		public ConnectableConfigData(LegacyConnectableLinkVisual FFHDEDFHGKP, bool BLHDDBKEJJJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OMPJHADMDBG : IEquatable<OMPJHADMDBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public KGJNPMKJIIA OAECINPEBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int LKOLHBGNLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int DOLFIDPOHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 FDLKFNIKBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion EABCELBPDPO;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E7D0", Offset = "0x7B8D7D0", VA = "0x187B8E7D0")]
	public OMPJHADMDBG(KGJNPMKJIIA OAECINPEBBO, int LKOLHBGNLLI, int DOLFIDPOHID, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E8C0", Offset = "0x7B8D8C0", VA = "0x187B8E8C0")]
	public OMPJHADMDBG(KGJNPMKJIIA OAECINPEBBO, int LKOLHBGNLLI, int DOLFIDPOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E830", Offset = "0x7B8D830", VA = "0x187B8E830")]
	public OMPJHADMDBG(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E350", Offset = "0x7B8D350", VA = "0x187B8E350", Slot = "4")]
	public bool Equals(OMPJHADMDBG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E400", Offset = "0x7B8D400", VA = "0x187B8E400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class PEHEEPPKBOM : BKFFNCAMMEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform KOOMPFGMBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private GCHDFMGBKEJ ONIONKMJCDK;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x756ADD0", Offset = "0x7569DD0", VA = "0x18756ADD0", Slot = "4")]
	public void ANJKPBDKBKO(Transform KOOMPFGMBLG, GCHDFMGBKEJ ONIONKMJCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7B944B0", Offset = "0x7B934B0", VA = "0x187B944B0", Slot = "5")]
	public GCHDFMGBKEJ KFOLADHCLIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7B94580", Offset = "0x7B93580", VA = "0x187B94580", Slot = "6")]
	public void LCHNIHMIAOB(GCHDFMGBKEJ BEOKGAIKNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PEHEEPPKBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NLOLJJFHFJL : IDisposable, MPDKCOBOEOI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FJDMMPFOFGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public KGJNPMKJIIA oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KGJNPMKJIIA newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FJDMMPFOFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B82980", Offset = "0x7B81980", VA = "0x187B82980")]
		internal bool DKNCELDKKPC(AFJPILNFMFC node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly ILMFMOKLFED CNPEJDKPHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NAGMEOCGGAJ GHEONPKHJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private PBKCFNFNJEG EIHAJEPOKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool BLHDDBKEJJJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly JBBHIJHGEPM DANCFBEKJGM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public AFJPILNFMFC FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C820", Offset = "0x7B8B820", VA = "0x187B8C820")]
	public bool JDECLKBDLHO([In] KMMPPAOLNAM APDBNIMCPID, bool DCGDGGMDIEE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C250", Offset = "0x7B8B250", VA = "0x187B8C250")]
	private bool FFDCNBEOANF([In] KMMPPAOLNAM APDBNIMCPID, bool DCGDGGMDIEE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DCC0", Offset = "0x7B8CCC0", VA = "0x187B8DCC0")]
	public NLOLJJFHFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B8ACF0", Offset = "0x7B89CF0", VA = "0x187B8ACF0", Slot = "5")]
	public void ANJKPBDKBKO(HAEKELLPJAC PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7B8ACC0", Offset = "0x7B89CC0", VA = "0x187B8ACC0", Slot = "17")]
	public void AMBFCMFFILO(FFFPIELDNIL COLEJLDPDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B0F0", Offset = "0x7B8A0F0", VA = "0x187B8B0F0", Slot = "12")]
	public void CCOFEINHDEF(Func<KGJNPMKJIIA, bool> BJPKHNCADHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B100", Offset = "0x7B8A100", VA = "0x187B8B100")]
	private void CCOFEINHDEF(ILMFMOKLFED GOJJJBGJPAM, Func<KGJNPMKJIIA, bool> BJPKHNCADHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CCA0", Offset = "0x7B8BCA0", VA = "0x187B8CCA0", Slot = "11")]
	public void KFPOLEFIECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B230", Offset = "0x7B8A230", VA = "0x187B8B230", Slot = "8")]
	public bool CGPDDOBFGIB(KGJNPMKJIIA CLKOCOADKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B940", Offset = "0x7B8A940", VA = "0x187B8B940")]
	private bool FDDKIMBNFJO(KGJNPMKJIIA CNCJAONEFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C830", Offset = "0x7B8B830", VA = "0x187B8C830")]
	private static bool GLPBBHNOHBH(KGJNPMKJIIA CNCJAONEFKE, ILMFMOKLFED DDMEELKFLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A8E0", Offset = "0x7B898E0", VA = "0x187B8A8E0")]
	private void ABFFKGFOIIA(Transform PJDGPDKLLOB, ILMFMOKLFED KCBLKELIMAJ, ILMFMOKLFED[] CCADDEKEMHH, KGJNPMKJIIA ALKFDFPDPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B440", Offset = "0x7B8A440", VA = "0x187B8B440")]
	private OMPJHADMDBG DPHAGLMLPIP(Transform IKHNBIGOHCA, OMPJHADMDBG FPOOFGMJFHI)
	{
		return default(OMPJHADMDBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C050", Offset = "0x7B8B050", VA = "0x187B8C050")]
	private static bool FEIKGOIMOJL(ILMFMOKLFED DDMEELKFLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B8E0", Offset = "0x7B8A8E0", VA = "0x187B8B8E0", Slot = "9")]
	public bool EOOIBLGMGDK(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CE40", Offset = "0x7B8BE40", VA = "0x187B8CE40")]
	private bool LHAHFAICMLC(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CCC0", Offset = "0x7B8BCC0", VA = "0x187B8CCC0")]
	private static void KMGGKMNFHEN(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO, ILMFMOKLFED GBCPONEKIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CA50", Offset = "0x7B8BA50", VA = "0x187B8CA50")]
	private void JAAGLKJFNJO(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D090", Offset = "0x7B8C090", VA = "0x187B8D090")]
	private void LJOKFDGFFPD(ILMFMOKLFED GOJJJBGJPAM, KGJNPMKJIIA ANIIDMDIGEL, KGJNPMKJIIA CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D100", Offset = "0x7B8C100", VA = "0x187B8D100")]
	private void LJOKFDGFFPD(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA ANIIDMDIGEL, KGJNPMKJIIA CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C8E0", Offset = "0x7B8B8E0", VA = "0x187B8C8E0")]
	private void INELCBADLIG(KGJNPMKJIIA OAECINPEBBO, KGJNPMKJIIA ANIIDMDIGEL, KGJNPMKJIIA CKMMPPDMABF, bool GOJAHFBBIEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C950", Offset = "0x7B8B950", VA = "0x187B8C950")]
	private void INELCBADLIG(ILMFMOKLFED KNNDNAPJIDP, KGJNPMKJIIA ALKFDFPDPEO, KGJNPMKJIIA GMAPFDOKMHL, bool GOJAHFBBIEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7B8AFD0", Offset = "0x7B89FD0", VA = "0x187B8AFD0")]
	private void CBABJCPBPHD(KGJNPMKJIIA HMCFPGIFOED, int GHHMMIAAMBI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7B8AE70", Offset = "0x7B89E70", VA = "0x187B8AE70")]
	private void BDPJJDCEPMM(AFJPILNFMFC JHDAOHEONAC, AFJPILNFMFC MIFGAFJFBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B2E0", Offset = "0x7B8A2E0", VA = "0x187B8B2E0", Slot = "18")]
	public KGJNPMKJIIA DCFAPKBHAIJ(KGJNPMKJIIA OAECINPEBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D710", Offset = "0x7B8C710", VA = "0x187B8D710", Slot = "13")]
	public void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> BAFCOLIJPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B590", Offset = "0x7B8A590", VA = "0x187B8B590", Slot = "14")]
	public List<KGJNPMKJIIA> EKDDKIAJEPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7B8ADA0", Offset = "0x7B89DA0", VA = "0x187B8ADA0")]
	protected AFJPILNFMFC ANOGKMJNPPE(AFJPILNFMFC GOJJJBGJPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B240", Offset = "0x7B8A240", VA = "0x187B8B240")]
	protected ILMFMOKLFED[] DACNDBPGPLB(ILMFMOKLFED DDMEELKFLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B7D0", Offset = "0x7B8A7D0", VA = "0x187B8B7D0")]
	protected bool EOBBOBJPPBG(KGJNPMKJIIA OAECINPEBBO, [Out] ILMFMOKLFED GOJJJBGJPAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DAC0", Offset = "0x7B8CAC0", VA = "0x187B8DAC0", Slot = "15")]
	public bool OHAGBJIFMMN(KGJNPMKJIIA OAECINPEBBO, [Out] OMPJHADMDBG AOIEEPOJLPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C210", Offset = "0x7B8B210", VA = "0x187B8C210")]
	protected ILMFMOKLFED FEKLJJLNDBG(OMPJHADMDBG MPAFKFEGGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CB70", Offset = "0x7B8BB70", VA = "0x187B8CB70", Slot = "10")]
	public bool JODLAOJBBKP(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D170", Offset = "0x7B8C170", VA = "0x187B8D170")]
	private bool MNNECBGLJMG(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CBD0", Offset = "0x7B8BBD0", VA = "0x187B8CBD0")]
	private static bool KDIGJDKFPMK(ILMFMOKLFED ANLDIJJMHIN, OMPJHADMDBG DOGAEAFCEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C820", Offset = "0x7B8B820", VA = "0x187B8C820", Slot = "7")]
	private bool FNHIDHABKEH([In] KMMPPAOLNAM APDBNIMCPID, bool DCGDGGMDIEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class DOPHNNLKEHE : HAEKELLPJAC, MMMIGLKPHHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly AINJBKKEAIL NELIKBMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly PBKCFNFNJEG EIHAJEPOKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly FKIDMBFCFFO JDDEPBEICGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly HGOJGPOGIKJ NLEKOAFJAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly MPDKCOBOEOI NOKCJFMDPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal NJBGDIJBDMG DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal DGLLIBDCCMB NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal NAGMEOCGGAJ NFONPELDILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool BLHDDBKEJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool NKFIACAHNOL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OJIKKLEMGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xBF24F0", Offset = "0xBF14F0", VA = "0x180BF24F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x124D2F0", Offset = "0x124C2F0", VA = "0x18124D2F0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x111F050", Offset = "0x111E050", VA = "0x18111F050", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x258CA80", Offset = "0x258BA80", VA = "0x18258CA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LEKOKFJOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7B808A0", Offset = "0x7B7F8A0", VA = "0x187B808A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B81560", Offset = "0x7B80560", VA = "0x187B81560", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B814A0", Offset = "0x7B804A0", VA = "0x187B814A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B81E00", Offset = "0x7B80E00", VA = "0x187B81E00", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B81500", Offset = "0x7B80500", VA = "0x187B81500", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7B81F70", Offset = "0x7B80F70", VA = "0x187B81F70", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B82590", Offset = "0x7B81590", VA = "0x187B82590")]
	public DOPHNNLKEHE(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7B80A60", Offset = "0x7B7FA60", VA = "0x187B80A60", Slot = "12")]
	public void ANJKPBDKBKO(GameObject CEKGANCAJPA, GMDBFGIIFFC GHDIGEKIHBA, EGONKLCENLD FEDKNCIDEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B81FD0", Offset = "0x7B80FD0", VA = "0x187B81FD0", Slot = "26")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7B815C0", Offset = "0x7B805C0", VA = "0x187B815C0", Slot = "13")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7B80A40", Offset = "0x7B7FA40", VA = "0x187B80A40", Slot = "14")]
	public void AMBIAOGNIIF(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7B81B30", Offset = "0x7B80B30", VA = "0x187B81B30", Slot = "15")]
	public void OMFPKPKPLOB(KGJNPMKJIIA OAECINPEBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7B821A0", Offset = "0x7B811A0", VA = "0x187B821A0", Slot = "22")]
	public bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7B81E60", Offset = "0x7B80E60", VA = "0x187B81E60")]
	internal bool MNNECBGLJMG([In] KMMPPAOLNAM APDBNIMCPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7B82440", Offset = "0x7B81440", VA = "0x187B82440")]
	internal bool PPAJOOFBJLK([In] KMMPPAOLNAM APDBNIMCPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7B810B0", Offset = "0x7B800B0", VA = "0x187B810B0")]
	internal void BHJAKOHDNEM(KGJNPMKJIIA OAECINPEBBO, int IJELAKPHHGP, bool DCGDGGMDIEE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7B81B30", Offset = "0x7B80B30", VA = "0x187B81B30")]
	internal bool LFABHOHGNOK(KGJNPMKJIIA PIPANKJNIHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7B81C20", Offset = "0x7B80C20", VA = "0x187B81C20")]
	internal bool MBBAHLLMNKE(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7B820A0", Offset = "0x7B810A0", VA = "0x187B820A0", Slot = "16")]
	public void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> FMCCIABOIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7B81290", Offset = "0x7B80290", VA = "0x187B81290", Slot = "17")]
	public void CHFGABCDLEC(KGJNPMKJIIA APNDBHICMDC, KGJNPMKJIIA NJNFNFBFADF, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7B80900", Offset = "0x7B7F900", VA = "0x187B80900", Slot = "18")]
	public void AKAEAHNKFMK(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7B81960", Offset = "0x7B80960", VA = "0x187B81960", Slot = "19")]
	public void JJEPLKJECKD(KGJNPMKJIIA JDEBBMOCGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7B821F0", Offset = "0x7B811F0", VA = "0x187B821F0")]
	public void PMFPDNNHHIP([Optional] NLDJFEFKCOP IFPPKLHLPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7B81B90", Offset = "0x7B80B90", VA = "0x187B81B90", Slot = "23")]
	public void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7B817E0", Offset = "0x7B807E0", VA = "0x187B817E0", Slot = "20")]
	public JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7B81640", Offset = "0x7B80640", VA = "0x187B81640", Slot = "21")]
	public JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7B81070", Offset = "0x7B80070", VA = "0x187B81070", Slot = "25")]
	public void BDHOBHEBPMH(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B81D50", Offset = "0x7B80D50", VA = "0x187B81D50", Slot = "24")]
	public void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class PBKCFNFNJEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly KICNHCAEGMA<KGJNPMKJIIA, KGJNPMKJIIA> KGOCIDFOONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly KICNHCAEGMA<KGJNPMKJIIA, KGJNPMKJIIA> GMKPBCMEFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly MOHJIJKGENJ<KGJNPMKJIIA, KGJNPMKJIIA, KGJNPMKJIIA> NFAKGCBAMFP;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7B94390", Offset = "0x7B93390", VA = "0x187B94390")]
	public PBKCFNFNJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	public void ANJKPBDKBKO(DOPHNNLKEHE PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7B94330", Offset = "0x7B93330", VA = "0x187B94330")]
	public void JDDDAEADMOB(KGJNPMKJIIA JHDAOHEONAC, KGJNPMKJIIA HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7B94250", Offset = "0x7B93250", VA = "0x187B94250")]
	public void BDMBLLKALMA(KGJNPMKJIIA JHDAOHEONAC, KGJNPMKJIIA HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7B942B0", Offset = "0x7B932B0", VA = "0x187B942B0")]
	public void GPDIFMPKHGD(KGJNPMKJIIA FKDPBFFLHKA, KGJNPMKJIIA FAMAONKAFDI, KGJNPMKJIIA HMCFPGIFOED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FKIDMBFCFFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private DOPHNNLKEHE PAKPDHLKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private DGLLIBDCCMB NODDAHEDIAD;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FKIDMBFCFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B82A40", Offset = "0x7B81A40", VA = "0x187B82A40")]
	public void ANJKPBDKBKO(DOPHNNLKEHE PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7B82BF0", Offset = "0x7B81BF0", VA = "0x187B82BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7B82E20", Offset = "0x7B81E20", VA = "0x187B82E20")]
	private void KPGHIHLMLLF(AEMMHEJJEHA LFJPHGCMAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B82B80", Offset = "0x7B81B80", VA = "0x187B82B80")]
	private void BOFMJJJDNII(NLDJFEFKCOP FCIPMBBCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7B82C00", Offset = "0x7B81C00", VA = "0x187B82C00")]
	public void HJAMBHFKBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7B82D10", Offset = "0x7B81D10", VA = "0x187B82D10")]
	public void KNHCFHPBDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OMJGJLBJLNK
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IPHPPMEBJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AINJBKKEAIL container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IPHPPMEBJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7B88F70", Offset = "0x7B87F70", VA = "0x187B88F70")]
		internal DOPHNNLKEHE GALEJCAFIPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E0D0", Offset = "0x7B8D0D0", VA = "0x187B8E0D0")]
	public static void KCIDEFBNJAG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E2D0", Offset = "0x7B8D2D0", VA = "0x187B8E2D0")]
	public static void KFBNFICJJPH(AINJBKKEAIL NELIKBMJKPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class PBAFKNEDMKB : IDisposable, NAGMEOCGGAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, GCHDFMGBKEJ> OGGAHOEKPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FFFPIELDNIL GGJNEIPHJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private BKFFNCAMMEA MCPGCAOOHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private MPDKCOBOEOI NOKCJFMDPME;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker LPFECODGPCB;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F650", Offset = "0x7B8E650", VA = "0x187B8F650")]
	public PBAFKNEDMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EAD0", Offset = "0x7B8DAD0", VA = "0x187B8EAD0", Slot = "7")]
	public void ANJKPBDKBKO(MPDKCOBOEOI NOKCJFMDPME, BKFFNCAMMEA MCPGCAOOHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F1D0", Offset = "0x7B8E1D0", VA = "0x187B8F1D0", Slot = "5")]
	public void IHCDDKGPLHB(AFJPILNFMFC JHFCBFNEHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E960", Offset = "0x7B8D960", VA = "0x187B8E960", Slot = "9")]
	public void ACPJNFDKFHA(AFJPILNFMFC FGAOOFFBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F010", Offset = "0x7B8E010", VA = "0x187B8F010", Slot = "8")]
	public void HHAGBNGFILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EB10", Offset = "0x7B8DB10", VA = "0x187B8EB10", Slot = "10")]
	public void FPAIGNFPNJH(AFJPILNFMFC JIIOPCFMGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F470", Offset = "0x7B8E470", VA = "0x187B8F470", Slot = "11")]
	public void KFGFAPMCHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EE60", Offset = "0x7B8DE60", VA = "0x187B8EE60")]
	private bool GLMNGAKOIDG(AFJPILNFMFC KLJKHLHNLGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class HGOJGPOGIKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct JIKFFNIDFBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ILMFMOKLFED FCNLLBJPCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> CCFFMIEIJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly FHKJOHOMFCJ NOGAGCIANOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly FHKJOHOMFCJ ELIBIGDCALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool BPJLOCGBNMG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool DHIAICGDGID
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7B89460", Offset = "0x7B88460", VA = "0x187B89460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7B898B0", Offset = "0x7B888B0", VA = "0x187B898B0")]
		public JIKFFNIDFBE(ILMFMOKLFED FCNLLBJPCOC, HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG, [Optional] FHKJOHOMFCJ NOGAGCIANOC, [Optional] FHKJOHOMFCJ ELIBIGDCALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7B89200", Offset = "0x7B88200", VA = "0x187B89200")]
		public FHKJOHOMFCJ DFNAEDFOBIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B893A0", Offset = "0x7B883A0", VA = "0x187B893A0")]
		private FHKJOHOMFCJ EOMNMNJENOC([Out] FHKJOHOMFCJ LEDBPNNMKIG, [Out] FHKJOHOMFCJ MMMDIAFLLEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7B88FE0", Offset = "0x7B87FE0", VA = "0x187B88FE0")]
		private FHKJOHOMFCJ CDFGICCPBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7B89740", Offset = "0x7B88740", VA = "0x187B89740")]
		private void LFHDAANJDAN(FHKJOHOMFCJ HKPGFEDCDFH, FHKJOHOMFCJ FDPNKIOKBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7B89580", Offset = "0x7B88580", VA = "0x187B89580")]
		private void JKDJGJDFDEP(FHKJOHOMFCJ LEDBPNNMKIG, FHKJOHOMFCJ MMMDIAFLLEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private DOPHNNLKEHE PAKPDHLKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private MPDKCOBOEOI NOKCJFMDPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NAGMEOCGGAJ GHEONPKHJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private DGLLIBDCCMB NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool AKLCKNMCPIN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool IEBIOFEFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B86630", Offset = "0x7B85630", VA = "0x187B86630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool OJIKKLEMGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7B86E30", Offset = "0x7B85E30", VA = "0x187B86E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7B86E10", Offset = "0x7B85E10", VA = "0x187B86E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7B85BE0", Offset = "0x7B84BE0", VA = "0x187B85BE0")]
	public void ANJKPBDKBKO(DOPHNNLKEHE PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7B86CA0", Offset = "0x7B85CA0", VA = "0x187B86CA0")]
	public JLPHBPPDHAI JHIANAELKAO(bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7B86910", Offset = "0x7B85910", VA = "0x187B86910")]
	public JLPHBPPDHAI IFAKLKFBAIA(HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7B86E50", Offset = "0x7B85E50", VA = "0x187B86E50")]
	public void LFKJPHLIEMM(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7B86F20", Offset = "0x7B85F20", VA = "0x187B86F20")]
	public void MHGECJEGKNL(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7B86480", Offset = "0x7B85480", VA = "0x187B86480")]
	public void FELJNIFNLCK(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7B86AB0", Offset = "0x7B85AB0", VA = "0x187B86AB0")]
	private void JBJIMPAFJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7B86250", Offset = "0x7B85250", VA = "0x187B86250")]
	private FHKJOHOMFCJ EBMOBKFKFED(ILMFMOKLFED GOJJJBGJPAM, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B878E0", Offset = "0x7B868E0", VA = "0x187B878E0")]
	private static void OFJBMJOLFLF(ILMFMOKLFED GOJJJBGJPAM, bool BPJLOCGBNMG, FHKJOHOMFCJ MECICAJOHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7B85C50", Offset = "0x7B84C50", VA = "0x187B85C50")]
	private void BGGDOGIBKMN(ILMFMOKLFED GOJJJBGJPAM, bool BPJLOCGBNMG, FHKJOHOMFCJ MECICAJOHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7B861C0", Offset = "0x7B851C0", VA = "0x187B861C0")]
	private FHKJOHOMFCJ COAGHNEPHCP(ILMFMOKLFED FCNLLBJPCOC, HashSet<Guid> CCFFMIEIJBC, bool BPJLOCGBNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7B86680", Offset = "0x7B85680", VA = "0x187B86680")]
	private bool HCMGHFIFLDC(JLPHBPPDHAI AJBLPHIOOHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7B86FE0", Offset = "0x7B85FE0", VA = "0x187B86FE0")]
	private bool ODGHMKJPKDN(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7B86FC0", Offset = "0x7B85FC0", VA = "0x187B86FC0")]
	private bool NIHBELLIFJH(JLPHBPPDHAI NOKCJFMDPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7B881B0", Offset = "0x7B871B0", VA = "0x187B881B0")]
	private static bool POAFOGAGKFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7B87650", Offset = "0x7B86650", VA = "0x187B87650")]
	public static bool OFABFJJKDFG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7B87CC0", Offset = "0x7B86CC0", VA = "0x187B87CC0")]
	private KGJNPMKJIIA OPMKLMMJJEG(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7B864B0", Offset = "0x7B854B0", VA = "0x187B864B0")]
	private KGJNPMKJIIA FNAMBHGNBPO(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7B88020", Offset = "0x7B87020", VA = "0x187B88020")]
	private KGJNPMKJIIA PDNHMHEJGEB(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7B86EE0", Offset = "0x7B85EE0", VA = "0x187B86EE0")]
	private static Guid LOELKJPBEAO(FHKJOHOMFCJ MECICAJOHBD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7B85E70", Offset = "0x7B84E70", VA = "0x187B85E70")]
	private string CCODCGDKILB(FHKJOHOMFCJ MECICAJOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7B87B30", Offset = "0x7B86B30", VA = "0x187B87B30")]
	private bool OKMKPEIAPEB(ILMFMOKLFED GOJJJBGJPAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7B85F60", Offset = "0x7B84F60", VA = "0x187B85F60")]
	private static void CLDPMBOGJOJ(ILMFMOKLFED FCNLLBJPCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HGOJGPOGIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KMMPPAOLNAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public KGJNPMKJIIA HMCFPGIFOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public KGJNPMKJIIA JHDAOHEONAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int GHHMMIAAMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int JFAHNBMPGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 FDLKFNIKBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion EABCELBPDPO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public OMPJHADMDBG PCAJPDECIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7B89950", Offset = "0x7B88950", VA = "0x187B89950")]
		get
		{
			return default(OMPJHADMDBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OMPJHADMDBG GIJALGGGOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7B89920", Offset = "0x7B88920", VA = "0x187B89920")]
		get
		{
			return default(OMPJHADMDBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B899F0", Offset = "0x7B889F0", VA = "0x187B899F0")]
	public KMMPPAOLNAM(KGJNPMKJIIA HMCFPGIFOED, KGJNPMKJIIA JHDAOHEONAC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MPDKCOBOEOI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AFJPILNFMFC FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANJKPBDKBKO(HAEKELLPJAC PAKPDHLKNJE);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDECLKBDLHO([In] KMMPPAOLNAM APDBNIMCPID, bool DCGDGGMDIEE = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CGPDDOBFGIB(KGJNPMKJIIA CLKOCOADKDB);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EOOIBLGMGDK(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JODLAOJBBKP(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFPOLEFIECO();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CCOFEINHDEF(Func<KGJNPMKJIIA, bool> BJPKHNCADHP);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJBHPGEALDE(KGJNPMKJIIA OAECINPEBBO, HashSet<KGJNPMKJIIA> BAFCOLIJPBE);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<KGJNPMKJIIA> EKDDKIAJEPO();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OHAGBJIFMMN(KGJNPMKJIIA OAECINPEBBO, [Out] OMPJHADMDBG AOIEEPOJLPG);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AMBFCMFFILO(FFFPIELDNIL COLEJLDPDCO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool FFFPIELDNIL(AFJPILNFMFC GOJJJBGJPAM);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface AFJPILNFMFC
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KGJNPMKJIIA FNJBEKNFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AFJPILNFMFC LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OMPJHADMDBG OOLJAJNEDND
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EKINFJGDGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GCHDFMGBKEJ
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEBICEODLFH(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECGMLFHIDFD(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIBADKJIJLK(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHEOKAAEIGJ(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GCHDFMGBKEJ Instantiate(Transform KOOMPFGMBLG);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMHHJKJOIHP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BKFFNCAMMEA
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANJKPBDKBKO(Transform KOOMPFGMBLG, GCHDFMGBKEJ ONIONKMJCDK);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GCHDFMGBKEJ KFOLADHCLIF();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCHNIHMIAOB(GCHDFMGBKEJ BEOKGAIKNCN);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NJBGDIJBDMG : HMHGMBFLDMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEDIGCEENCF();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLIPENJKIEG(Guid CJHMIILEEBE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NAGMEOCGGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHCDDKGPLHB(AFJPILNFMFC JHFCBFNEHKP);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANJKPBDKBKO(MPDKCOBOEOI NOKCJFMDPME, BKFFNCAMMEA DGDMEHGDCHD);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHAGBNGFILH();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACPJNFDKFHA(AFJPILNFMFC FGAOOFFBEDC);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPAIGNFPNJH(AFJPILNFMFC JIIOPCFMGCK);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFGFAPMCHKC();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class ILMFMOKLFED : AFJPILNFMFC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CJJPLPFLCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public OMPJHADMDBG nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public ILMFMOKLFED foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CJJPLPFLCJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B80230", Offset = "0x7B7F230", VA = "0x187B80230")]
		internal bool IMMAEKIPFBF(AFJPILNFMFC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private OMPJHADMDBG AOIEEPOJLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<ILMFMOKLFED> CKOCFIAIKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ILMFMOKLFED FOEJNPDDMEA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public OMPJHADMDBG OOLJAJNEDND
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x124DC10", Offset = "0x124CC10", VA = "0x18124DC10", Slot = "6")]
		get
		{
			return default(OMPJHADMDBG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x124D5E0", Offset = "0x124C5E0", VA = "0x18124D5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private ILMFMOKLFED JHDAOHEONAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B88A50", Offset = "0x7B87A50", VA = "0x187B88A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AFJPILNFMFC LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KGJNPMKJIIA FNJBEKNFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EKINFJGDGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B88EB0", Offset = "0x7B87EB0", VA = "0x187B88EB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LMGKHBPOFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B886D0", Offset = "0x7B876D0", VA = "0x187B886D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected ILMFMOKLFED KNNDNAPJIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B885B0", Offset = "0x7B875B0", VA = "0x187B885B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B88EC0", Offset = "0x7B87EC0", VA = "0x187B88EC0")]
	public ILMFMOKLFED(OMPJHADMDBG GKCMEHIPMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B88B30", Offset = "0x7B87B30", VA = "0x187B88B30")]
	public ILMFMOKLFED JHHBOOEOKAN(OMPJHADMDBG OHBKJPBDAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B88D30", Offset = "0x7B87D30", VA = "0x187B88D30")]
	public ILMFMOKLFED OGACJCJBLKD(OMPJHADMDBG LGJDPFBOMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B88720", Offset = "0x7B87720", VA = "0x187B88720")]
	public ILMFMOKLFED GNAALOCCJEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B88900", Offset = "0x7B87900", VA = "0x187B88900")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B88C80", Offset = "0x7B87C80", VA = "0x187B88C80")]
	public ILMFMOKLFED KEDOMLCMECI(OMPJHADMDBG FAMAONKAFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B88450", Offset = "0x7B87450", VA = "0x187B88450")]
	private static void AMBFCMFFILO(ILMFMOKLFED KJMKLBFBJEK, FFFPIELDNIL AOHGJNGCBBI, bool ECMEOAHDOMI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B88440", Offset = "0x7B87440", VA = "0x187B88440", Slot = "9")]
	public void AMBFCMFFILO(FFFPIELDNIL COLEJLDPDCO, bool GOJAHFBBIEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B885D0", Offset = "0x7B875D0", VA = "0x187B885D0")]
	public static ILMFMOKLFED FEKLJJLNDBG(ILMFMOKLFED KJMKLBFBJEK, OMPJHADMDBG EAEGAHLKDDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface DGLLIBDCCMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IEBIOFEFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<AEMMHEJJEHA> KPGHIHLMLLF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<NLDJFEFKCOP> BOFMJJJDNII;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EEBICEODLFH(DOPHNNLKEHE PAKPDHLKNJE, EGONKLCENLD FJLMGGKGAOO);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHFGABCDLEC(KGJNPMKJIIA APNDBHICMDC, KGJNPMKJIIA NJNFNFBFADF, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AKAEAHNKFMK(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GCDCMBINAOF(JLPHBPPDHAI FNLMKKLNMCA, [Optional] NLDJFEFKCOP IFPPKLHLPGC);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IBKFCLIIFOL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B883E0", Offset = "0x7B873E0", VA = "0x187B883E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B883A0", Offset = "0x7B873A0", VA = "0x187B883A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B88340", Offset = "0x7B87340", VA = "0x187B88340")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class HCKCCIBMGNG : DGLLIBDCCMB, IDisposable, CFOOLLLNECM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private DOPHNNLKEHE PAKPDHLKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private EGONKLCENLD FEDKNCIDEOI;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool IEBIOFEFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B85240", Offset = "0x7B84240", VA = "0x187B85240", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CHECBKFCEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B853F0", Offset = "0x7B843F0", VA = "0x187B853F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView PFFFFPLBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B851B0", Offset = "0x7B841B0", VA = "0x187B851B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<AEMMHEJJEHA> KPGHIHLMLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B852A0", Offset = "0x7B842A0", VA = "0x187B852A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B85430", Offset = "0x7B84430", VA = "0x187B85430", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NLDJFEFKCOP> BOFMJJJDNII
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B84EF0", Offset = "0x7B83EF0", VA = "0x187B84EF0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B85340", Offset = "0x7B84340", VA = "0x187B85340", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B84FF0", Offset = "0x7B83FF0", VA = "0x187B84FF0", Slot = "10")]
	public void EEBICEODLFH(DOPHNNLKEHE PAKPDHLKNJE, EGONKLCENLD FEDKNCIDEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B84FA0", Offset = "0x7B83FA0", VA = "0x187B84FA0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B84DC0", Offset = "0x7B83DC0", VA = "0x187B84DC0", Slot = "11")]
	public void CHFGABCDLEC(KGJNPMKJIIA APNDBHICMDC, KGJNPMKJIIA NJNFNFBFADF, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B84C90", Offset = "0x7B83C90", VA = "0x187B84C90", Slot = "12")]
	public void AKAEAHNKFMK(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7B85080", Offset = "0x7B84080", VA = "0x187B85080", Slot = "13")]
	public void GCDCMBINAOF(JLPHBPPDHAI FNLMKKLNMCA, [Optional] NLDJFEFKCOP IFPPKLHLPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7B85710", Offset = "0x7B84710", VA = "0x187B85710")]
	[NNJDEPHNONO]
	private void RpcMasterReparentNodes(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B85510", Offset = "0x7B84510", VA = "0x187B85510")]
	[NNJDEPHNONO]
	private void RpcMasterModifyNode(KGJNPMKJIIA APNDBHICMDC, KGJNPMKJIIA NJNFNFBFADF, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7B85AE0", Offset = "0x7B84AE0", VA = "0x187B85AE0")]
	[NNJDEPHNONO]
	private void RpcReparentNodes(KGJNPMKJIIA JDEBBMOCGLI, int FGFHPLCBDFI, KGJNPMKJIIA FAMAONKAFDI, int OHFINMJADPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO, ADKOONPNFKJ MAJHNAOMFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7B85A20", Offset = "0x7B84A20", VA = "0x187B85A20")]
	[NNJDEPHNONO]
	private void RpcModifyNode(KGJNPMKJIIA APNDBHICMDC, int GHHMMIAAMBI, int JFAHNBMPGPB, Vector3 FDLKFNIKBIK, Quaternion EABCELBPDPO, ADKOONPNFKJ MAJHNAOMFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7B854D0", Offset = "0x7B844D0", VA = "0x187B854D0")]
	[NNJDEPHNONO]
	private void RpcDeserializeConnectableGraph(JLPHBPPDHAI NOKCJFMDPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HCKCCIBMGNG()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, GCHDFMGBKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B89C50", Offset = "0x7B88C50", VA = "0x187B89C50", Slot = "4")]
		private void EJNKFEJFIDK(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B89DD0", Offset = "0x7B88DD0", VA = "0x187B89DD0", Slot = "5")]
		private void IOMADFNHCFK(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A050", Offset = "0x7B89050", VA = "0x187B8A050", Slot = "6")]
		private void MLBLBGOANDA(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B89A60", Offset = "0x7B88A60", VA = "0x187B89A60", Slot = "7")]
		private void EBCBLJCBGGG(KGJNPMKJIIA HKFAMNCINCG, OMPJHADMDBG HMCFPGIFOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A210", Offset = "0x7B89210", VA = "0x187B8A210", Slot = "8")]
		private GCHDFMGBKEJ PLOIOGDCOHN(Transform KOOMPFGMBLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A1B0", Offset = "0x7B891B0", VA = "0x187B8A1B0", Slot = "9")]
		private void ONKCDGJLFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IEKCPIAHFFN
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x387CCF0", Offset = "0x387BCF0", VA = "0x18387CCF0")]
	public static NIBLMNJEPNB<T> NOGKGBMDBDP<T>(this AINJBKKEAIL NELIKBMJKPH)
	{
		return null;
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

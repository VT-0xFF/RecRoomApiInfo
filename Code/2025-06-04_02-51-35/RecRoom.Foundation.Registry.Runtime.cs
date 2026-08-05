using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Foundation_Registry_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2D30", Offset = "0x7FC1530", VA = "0x187FC2D30", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HIBPMBACBKB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly string[] BHKPFMINFGA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly string[] IMKAMJAMDIP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static List<AssemblyIndex> JOIONBNNGPN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static bool HIIPNIGEIHC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly object CBLICAAJICI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static List<AssemblyIndex> OPALHMOBAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1460", Offset = "0x7FBFC60", VA = "0x187FC1460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FC12F0", Offset = "0x7FBFAF0", VA = "0x187FC12F0")]
	public static List<AssemblyIndex> IEAMPCKAMFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0FF0", Offset = "0x7FBF7F0", VA = "0x187FC0FF0")]
	private static void FMCIDDPGAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0E00", Offset = "0x7FBF600", VA = "0x187FC0E00")]
	private static void FKHPGBPCPGN(Assembly BMHODHIENMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0CD0", Offset = "0x7FBF4D0", VA = "0x187FC0CD0")]
	[CompilerGenerated]
	internal static bool CBFODAGNPOJ(string HPANEBBHGAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CBFAJBICHFE : IComponentDefaultRegistration, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JJHINBMANFC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NativeList<byte> FLHFCEEIHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NativeParallelHashMap<int, (int offset, int length)> NLJKLGJBAPL;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2C80", Offset = "0x7FC1480", VA = "0x187FC2C80")]
		public static JJHINBMANFC NCEFOOPFBNH(int BEMGFNOEFHN)
		{
			return default(JJHINBMANFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2C70", Offset = "0x7FC1470", VA = "0x187FC2C70")]
		public void EBKFCGEKMKA([Out] NativeList<byte> FLHFCEEIHBP, [Out] NativeParallelHashMap<int, (int offset, int length)> NLJKLGJBAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2BD0", Offset = "0x7FC13D0", VA = "0x187FC2BD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly JJHINBMANFC[] NAPFLDCMKIC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0760", Offset = "0x7FBEF60", VA = "0x187FC0760")]
	public CBFAJBICHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FBFE00", Offset = "0x7FBE600", VA = "0x187FBFE00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0050", Offset = "0x7FBE850", VA = "0x187FC0050")]
	public FIAGHJEMHMN HEBJHFDPFGC()
	{
		return default(FIAGHJEMHMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FC05D0", Offset = "0x7FBEDD0", VA = "0x187FC05D0", Slot = "4")]
	public void RegisterComponentDefault(Type CEPGAJKBPDM, int EKJJMBEOJHC, Span<byte> LLNMEIMBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FBFF10", Offset = "0x7FBE710", VA = "0x187FBFF10")]
	private void EIHAELMJEDM(int BEIKFCEAAEK, int EKJJMBEOJHC, Span<byte> LLNMEIMBBLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EGLGFLKKCDK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Flags]
	public enum FKGMDDOGENB
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Configurable = 1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public IPJNDDIPFFH BGONFJECOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int GPANGJPBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int JCHOPLCFCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FKGMDDOGENB NMFHGOAHANN;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0A90", Offset = "0x7FBF290", VA = "0x187FC0A90")]
	public EGLGFLKKCDK(IPJNDDIPFFH BGONFJECOMH, int GPANGJPBGDP, int JCHOPLCFCCE, FKGMDDOGENB NMFHGOAHANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IPJNDDIPFFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public string HPANEBBHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int IAOOMFIBPGC;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xC9CD20", Offset = "0xC9B520", VA = "0x180C9CD20")]
	public IPJNDDIPFFH(string HPANEBBHGAC, int IAOOMFIBPGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FIAGHJEMHMN
{
	[StructLayout((LayoutKind)0, Size = 64)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IIKDLLOKAFK
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	private readonly NativeArray<byte> FLHFCEEIHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	private readonly NativeParallelHashMap<int, (int offset, int length)> NLJKLGJBAPL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly IIKDLLOKAFK EMNFDOBKJKO;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0AE0", Offset = "0x7FBF2E0", VA = "0x187FC0AE0")]
	internal void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39BA680", Offset = "0x39B8E80", VA = "0x1839BA680")]
	public T LKFDKIFAIMH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FC0BA0", Offset = "0x7FBF3A0", VA = "0x187FC0BA0")]
	public NativeArray<byte> LKFDKIFAIMH(int BEIKFCEAAEK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x524B4E0", Offset = "0x5249CE0", VA = "0x18524B4E0")]
	public FIAGHJEMHMN(NativeArray<byte> FLHFCEEIHBP, NativeParallelHashMap<int, (int offset, int length)> NLJKLGJBAPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface OICKEBKHCLG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Type DCDJMNBOPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Type[] ICEKOMGKNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IReadOnlyDictionary<Type, LDGELEEMLDM> GDKMDEPOKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIIJAANLECF(IComponentDefaultRegistration HHPPDOFPEMC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface OIBHPNJICMK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Type[] LFLKEOALPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NativeArray<int> CFNGFLKAOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NativeArray<int> LPIGOLJADLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NativeBitArray FHBHDOBBCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NativeBitArray JOMPFKPOOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NativeParallelHashSet<int> EGGDMKMKJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Type[] ELOOJNJCMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	AHCNBJOLLKI[] NMJCHFIHALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Dictionary<int, EGLGFLKKCDK> OBFEDIIAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LDGELEEMLDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Type CEPGAJKBPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int[] AKCAGJDCCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Func<Entity, object, object> GJJHHKPDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Func<Entity, object, object> GBIJDPLLNHI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct AHCNBJOLLKI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[Flags]
	public enum KFCBJMLCOME
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Disabled = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Configurable = 2
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public IPJNDDIPFFH BGONFJECOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public string KALNKAJKGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public KFCBJMLCOME NMFHGOAHANN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NNGEEOEJGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6D10", Offset = "0x6DE5510", VA = "0x186DE6D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LMGMJMBPAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6DE6D30", Offset = "0x6DE5530", VA = "0x186DE6D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string BLOLJFFAKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FBFD80", Offset = "0x7FBE580", VA = "0x187FBFD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FBFDC0", Offset = "0x7FBE5C0", VA = "0x187FBFDC0")]
	public AHCNBJOLLKI([Optional] string JJMFACKKKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC480", Offset = "0x5EBAC80", VA = "0x185EBC480")]
	public AHCNBJOLLKI(IPJNDDIPFFH LCPLPGNINPG, string AHKKKFOPOCC, KFCBJMLCOME NMFHGOAHANN, [Optional] string JJMFACKKKGD)
	{
	}
}
namespace RecRoom.Foundation.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class Registry
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class TypeRegistration : ITypeRegistration
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4A60", Offset = "0x7FC3260", VA = "0x187FC4A60", Slot = "4")]
			public void RegisterTypes(Type attribute, params Type[] types)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4900", Offset = "0x7FC3100", VA = "0x187FC4900", Slot = "5")]
			public void RegisterMethods(Type attribute, params Delegate[] delegates)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public TypeRegistration()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly string[] ServiceCategories;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly BMELPJIFPCL log;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool isInitialized;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static bool isAppDomainUnloadRegistered;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Dictionary<Type, List<Type>> typeRegistry;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Dictionary<Type, List<Delegate>> methodRegistry;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly List<Type> emptyTypeList;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly List<Delegate> emptyMethodList;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static CEJNMCMOCOK dataLayerServices;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static OICKEBKHCLG dataLayerRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static OIBHPNJICMK networkPropertyRegistry;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static HLPOCICDIMM serviceCategories;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static OIBHPNJICMK NetworkProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7FC46B0", Offset = "0x7FC2EB0", VA = "0x187FC46B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static List<Type> SingletonComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4700", Offset = "0x7FC2F00", VA = "0x187FC4700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static Type[] NetworkComponentTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7FC44D0", Offset = "0x7FC2CD0", VA = "0x187FC44D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IReadOnlyDictionary<Type, LDGELEEMLDM> NetworkInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7FC45C0", Offset = "0x7FC2DC0", VA = "0x187FC45C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static FIAGHJEMHMN Defaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4470", Offset = "0x7FC2C70", VA = "0x187FC4470")]
			[CompilerGenerated]
			get
			{
				return default(FIAGHJEMHMN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7FC48A0", Offset = "0x7FC30A0", VA = "0x187FC48A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D02FA0", Offset = "0x3D017A0", VA = "0x183D02FA0")]
		public static List<Type> GetTypeList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3080", Offset = "0x7FC1880", VA = "0x187FC3080")]
		public static List<Type> GetTypeList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D02F20", Offset = "0x3D01720", VA = "0x183D02F20")]
		public static List<Delegate> GetMethodList<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2FC0", Offset = "0x7FC17C0", VA = "0x187FC2FC0")]
		public static List<Delegate> GetMethodList(Type attributeType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D01D40", Offset = "0x3D00540", VA = "0x183D01D40")]
		public static T GetDefault<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2E00", Offset = "0x7FC1600", VA = "0x187FC2E00")]
		public static NativeArray<byte> GetDefault(int typeIndex)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3140", Offset = "0x7FC1940", VA = "0x187FC3140")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3C50", Offset = "0x7FC2450", VA = "0x187FC3C50")]
		public static void RegisterServicesWithAny(this CEJNMCMOCOK services, params string[] any)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3CC0", Offset = "0x7FC24C0", VA = "0x187FC3CC0")]
		public static void RegisterServicesWithNone(this CEJNMCMOCOK services, params string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3DE0", Offset = "0x7FC25E0", VA = "0x187FC3DE0")]
		public static void RegisterServices(this CEJNMCMOCOK services, [Optional] string[] all, [Optional] string[] any, [Optional] string[] none)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3FE0", Offset = "0x7FC27E0", VA = "0x187FC3FE0")]
		public static void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3D30", Offset = "0x7FC2530", VA = "0x187FC3D30")]
		private static void RegisterServices(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC35F0", Offset = "0x7FC1DF0", VA = "0x187FC35F0")]
		private static void RegisterDataLayer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3E90", Offset = "0x7FC2690", VA = "0x187FC3E90")]
		private static void RegisterTypes(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3B00", Offset = "0x7FC2300", VA = "0x187FC3B00")]
		private static void RegisterMethods(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC37A0", Offset = "0x7FC1FA0", VA = "0x187FC37A0")]
		private static void RegisterDefaults(List<AssemblyIndex> assemblyIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FC40F0", Offset = "0x7FC28F0", VA = "0x187FC40F0")]
		private static void ThrowIfUninitialized()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HLPOCICDIMM : IServiceRegistration
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly ProfilerMarker PAJEJNGGGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly List<AssemblyIndex> HPINMEHPALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly List<(ServiceBitset, AssemblyIndex)> LOFHGGGEMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<ServiceBitset, List<AssemblyIndex>> CNJGNPKPELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly Dictionary<string, int> MGNDAPCPJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly string[] OGAIKOCKGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private CEJNMCMOCOK NOKFLPEFADE;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FC2590", Offset = "0x7FC0D90", VA = "0x187FC2590")]
	public HLPOCICDIMM(List<AssemblyIndex> FBLJHMINBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1D80", Offset = "0x7FC0580", VA = "0x187FC1D80")]
	public void KELFLPPCOLM(CEJNMCMOCOK NOKFLPEFADE, string[] FFINLGJLIII, string[] FBGDHNOHAKL, string[] ANBKMELLLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7FC2100", Offset = "0x7FC0900", VA = "0x187FC2100")]
	private ServiceBitsetFilter LPOOOHLFNPK(string[] FFINLGJLIII, string[] FBGDHNOHAKL, string[] ANBKMELLLAA)
	{
		return default(ServiceBitsetFilter);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1CC0", Offset = "0x7FC04C0", VA = "0x187FC1CC0")]
	private ServiceBitset JJKMBOGAFEM(string[] OGAIKOCKGJE)
	{
		return default(ServiceBitset);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1800", Offset = "0x7FC0000", VA = "0x187FC1800")]
	private List<AssemblyIndex> CPKPPNECNBH(ServiceBitsetFilter EBOCNBPJGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1BC0", Offset = "0x7FC03C0", VA = "0x187FC1BC0", Slot = "4")]
	public bool CanBind(Type EEEBONFKHOM, [Out] Lifetime FEPGBNHMDBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1AA0", Offset = "0x7FC02A0", VA = "0x187FC1AA0", Slot = "6")]
	public ulong CanBindAny(Type[] GFEDPDMABDJ, [Out] Lifetime FEPGBNHMDBD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FC2200", Offset = "0x7FC0A00", VA = "0x187FC2200", Slot = "5")]
	public void Register(Type EEEBONFKHOM, Lifetime FEPGBNHMDBD, object CMJLAOBGHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7FC2360", Offset = "0x7FC0B60", VA = "0x187FC2360", Slot = "7")]
	public void Register(Type[] GFEDPDMABDJ, Lifetime FEPGBNHMDBD, ulong CGLFEDOLDAB, object CMJLAOBGHAL)
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

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UFSCIDMSTJW
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9D92480", Offset = "0x9D91480", VA = "0x189D92480")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
	public UFSCIDMSTJW()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_OnlineRestrictions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D92560", Offset = "0x9D91560", VA = "0x189D92560", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : DKUBAVTRTKF
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class STDAUCQMYAC<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<PHCALMFWHCU, a> NSQQGGYVQDS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a GKUOXQORORP;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public STDAUCQMYAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9B90", Offset = "0x7AC8B90", VA = "0x187AC9B90")]
			internal bool GJPPSRUJJLK(PHCALMFWHCU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GPUZHZHBUVF<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> RELKNQKCGMZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<PHCALMFWHCU, a> NSQQGGYVQDS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a GKUOXQORORP;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GPUZHZHBUVF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x644BB00", Offset = "0x644AB00", VA = "0x18644BB00")]
			internal bool YPALWNXYOMB(PHCALMFWHCU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<PHCALMFWHCU> OMRPTVPAPTO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<PHCALMFWHCU> HJGUCVFJPUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9D8F5D0", Offset = "0x9D8E5D0", VA = "0x189D8F5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9D914E0", Offset = "0x9D904E0", VA = "0x189D914E0")]
		[GQJUYEPYYUG.Root.GameOnly]
		internal static void WVJSVKLWAIO(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D907D0", Offset = "0x9D8F7D0", VA = "0x189D907D0")]
		private bool SDZANHQKTEI(Func<PHCALMFWHCU, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F440", Offset = "0x9D8E440", VA = "0x189D8F440")]
		private bool INKRHVMQGCZ(Func<PHCALMFWHCU, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D71540", Offset = "0x3D70540", VA = "0x183D71540")]
		private bool UZQCJBUNXXM<a>(a a, Func<PHCALMFWHCU, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D71290", Offset = "0x3D70290", VA = "0x183D71290")]
		private bool HPRPFHVXEUZ<b>(b a, Func<PHCALMFWHCU, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9D8FC20", Offset = "0x9D8EC20", VA = "0x189D8FC20", Slot = "4")]
		public bool KPRRXCOYTTJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9D901E0", Offset = "0x9D8F1E0", VA = "0x189D901E0", Slot = "5")]
		public bool NYAPJSDGZUW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9D91160", Offset = "0x9D90160", VA = "0x189D91160", Slot = "6")]
		public bool VPRLKSVYULG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E7C0", Offset = "0x9D8D7C0", VA = "0x189D8E7C0", Slot = "7")]
		public bool ALRNANEDAUA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D8FF90", Offset = "0x9D8EF90", VA = "0x189D8FF90", Slot = "8")]
		public bool MLKLTRWWLUS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9D90F60", Offset = "0x9D8FF60", VA = "0x189D90F60", Slot = "9")]
		public bool UZKIRRDEBHZ(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F9D0", Offset = "0x9D8E9D0", VA = "0x189D8F9D0", Slot = "10")]
		public bool JVKJMBWMIGE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9D90560", Offset = "0x9D8F560", VA = "0x189D90560", Slot = "11")]
		public bool QFLYSKYZTWB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D8FD40", Offset = "0x9D8ED40", VA = "0x189D8FD40", Slot = "12")]
		public bool LXOUOTGPQXO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9D90D10", Offset = "0x9D8FD10", VA = "0x189D90D10", Slot = "13")]
		public bool UOWNIKIFNSJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D8EE70", Offset = "0x9D8DE70", VA = "0x189D8EE70", Slot = "14")]
		public bool GEIXZSBPOFF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F0C0", Offset = "0x9D8E0C0", VA = "0x189D8F0C0", Slot = "15")]
		public bool HPXBFVIYCLA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9D91700", Offset = "0x9D90700", VA = "0x189D91700", Slot = "16")]
		public bool YPDGJWJUDPS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D90A90", Offset = "0x9D8FA90", VA = "0x189D90A90", Slot = "17")]
		public bool UEEZVULEOOF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F1E0", Offset = "0x9D8E1E0", VA = "0x189D8F1E0", Slot = "18")]
		public bool HQCFNMMMXNG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9D8FE60", Offset = "0x9D8EE60", VA = "0x189D8FE60", Slot = "19")]
		public bool MLIVPVBRNXO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F880", Offset = "0x9D8E880", VA = "0x189D8F880", Slot = "20")]
		public bool JJYDUOATSOZ(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9D90BC0", Offset = "0x9D8FBC0", VA = "0x189D90BC0", Slot = "21")]
		public bool ULABPHTKOUU(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D90E30", Offset = "0x9D8FE30", VA = "0x189D90E30", Slot = "22")]
		public bool UTZQDZPPHZF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9D8EF90", Offset = "0x9D8DF90", VA = "0x189D8EF90", Slot = "23")]
		public bool HCILEYTHUYL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D90960", Offset = "0x9D8F960", VA = "0x189D90960", Slot = "24")]
		public bool TBOXADLZLHY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9D90430", Offset = "0x9D8F430", VA = "0x189D90430", Slot = "25")]
		public bool PZLIHOVCQPM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9D8FAF0", Offset = "0x9D8EAF0", VA = "0x189D8FAF0", Slot = "26")]
		public bool KJGMAEVBGRB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9D913B0", Offset = "0x9D903B0", VA = "0x189D913B0", Slot = "27")]
		public bool WDSBPIRESPF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9D8EC70", Offset = "0x9D8DC70", VA = "0x189D8EC70", Slot = "28")]
		public bool FLUWUZNRSDE(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F310", Offset = "0x9D8E310", VA = "0x189D8F310", Slot = "29")]
		public bool IDRCFTMDIPA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E8E0", Offset = "0x9D8D8E0", VA = "0x189D8E8E0", Slot = "30")]
		public bool BAKTDGSYFOF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9D8EB40", Offset = "0x9D8DB40", VA = "0x189D8EB40", Slot = "31")]
		public bool EROVXJSBZPH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9D91280", Offset = "0x9D90280", VA = "0x189D91280", Slot = "32")]
		public bool VSPOAZMPESK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D90680", Offset = "0x9D8F680", VA = "0x189D90680", Slot = "33")]
		public bool RJPYKTAORDK(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E690", Offset = "0x9D8D690", VA = "0x189D8E690", Slot = "34")]
		public bool AHYEWMTGTTP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9D900B0", Offset = "0x9D8F0B0", VA = "0x189D900B0", Slot = "35")]
		public bool NINPQKZCXMN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D8EA10", Offset = "0x9D8DA10", VA = "0x189D8EA10", Slot = "36")]
		public bool ELSYLRYGBQG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D915D0", Offset = "0x9D905D0", VA = "0x189D915D0", Slot = "37")]
		public bool YFQYTBBVIIV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9D90300", Offset = "0x9D8F300", VA = "0x189D90300", Slot = "38")]
		public bool OCCGXBARHCI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9D8EDC0", Offset = "0x9D8DDC0", VA = "0x189D8EDC0", Slot = "39")]
		public string GECYAYHAIDW(OnlineRestrictionsSources a)
		{
			return null;
		}
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

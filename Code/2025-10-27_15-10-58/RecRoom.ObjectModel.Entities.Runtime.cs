using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.ComponentSystems;
using RecRoom.NoEngine.JetBrains.Annotations;
using RecRoom.ObjectModel.Entities;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88E1010", Offset = "0x88E0010", VA = "0x1888E1010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MZHUOFNWOZJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
	public MZHUOFNWOZJ()
	{
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88E0C50", Offset = "0x88DFC50", VA = "0x1888E0C50")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FYGQFIOIZRI : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TokenHandle TokenHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface TLCULXJEXMG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JVLWNOYTBVP(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QRMJDNETMPY(Entity a, object b, [Out] bool c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool UXYCQQREGSR(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VHICCNRKUFP<a, b> : FGTFWKHYMUN<b>, IDisposable where a : struct, FYGQFIOIZRI
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class APCRZWCYYUG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private List<(object token, b value)> HIJIWAITELH;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int ZRHYXWVKFWI
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xBBC890", Offset = "0xBBB890", VA = "0x180BBC890")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x57DD3E0", Offset = "0x57DC3E0", VA = "0x1857DD3E0")]
			public bool YGFNQQNIETU([Out] b a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x57DCB50", Offset = "0x57DBB50", VA = "0x1857DCB50")]
			public void Add(object token, b value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x57DCF30", Offset = "0x57DBF30", VA = "0x1857DCF30")]
			public bool Remove(object token)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x57DD000", Offset = "0x57DC000", VA = "0x1857DD000")]
			public int XHFPNJIIPWS(object a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x57DD450", Offset = "0x57DC450", VA = "0x1857DD450")]
			public APCRZWCYYUG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Stack<APCRZWCYYUG> LBWZXPGMSEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ManagedObjectPool<TokenHandle, APCRZWCYYUG> GDPSJHWJWUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private EntityManager LYBZDVZGVAR;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66C1D30", Offset = "0x66C0D30", VA = "0x1866C1D30")]
		public VHICCNRKUFP(EntityManager a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x66C0E00", Offset = "0x66BFE00", VA = "0x1866C0E00", Slot = "4")]
		public void JVLWNOYTBVP(Entity a, object b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66C13E0", Offset = "0x66C03E0", VA = "0x1866C13E0", Slot = "5")]
		public bool QRMJDNETMPY(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x66C1B00", Offset = "0x66C0B00", VA = "0x1866C1B00", Slot = "6")]
		public bool YGFNQQNIETU(Entity a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x66C0B80", Offset = "0x66BFB80", VA = "0x1866C0B80", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x66C1A20", Offset = "0x66C0A20", VA = "0x1866C1A20")]
		private void XVJVHKSMNRM(APCRZWCYYUG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x66C1970", Offset = "0x66C0970", VA = "0x1866C1970")]
		private bool URKTGHUQTOY(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x66C0FD0", Offset = "0x66BFFD0", VA = "0x1866C0FD0")]
		private void NHFCFYZPIEU(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66C1360", Offset = "0x66C0360", VA = "0x1866C1360")]
		private bool PBGDXWZWPPA(TokenHandle a, [Out] APCRZWCYYUG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66C0AE0", Offset = "0x66BFAE0", VA = "0x1866C0AE0")]
		private APCRZWCYYUG AFPRYDOYTPM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface FGTFWKHYMUN<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JVLWNOYTBVP(Entity a, object b, a c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QRMJDNETMPY(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool YGFNQQNIETU(Entity a, [Out] a b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct TokenHandle : DCWCRPUQWSC, IEquatable<TokenHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly TokenHandle Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x16602A0", Offset = "0x165F2A0", VA = "0x1816602A0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[CreateProperty]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x30BACC0", Offset = "0x30B9CC0", VA = "0x1830BACC0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x30BACD0", Offset = "0x30B9CD0", VA = "0x1830BACD0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88E1A70", Offset = "0x88E0A70", VA = "0x1888E1A70", Slot = "8")]
		public bool Equals(TokenHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88E1AC0", Offset = "0x88E0AC0", VA = "0x1888E1AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class HHHKZKPSMLW<a> : TLCULXJEXMG, IDisposable where a : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Entity, TokenHandle> YQWFECUSVKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Stack<HashSet<object>> LBWZXPGMSEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ManagedObjectPool<TokenHandle, HashSet<object>> GDPSJHWJWUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EntityManager LYBZDVZGVAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private EntityCommandBufferSystem LKKDEBZOKWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool DWPOZTULXGS;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x52696D0", Offset = "0x52686D0", VA = "0x1852696D0")]
		public HHHKZKPSMLW(EntityManager a, EntityCommandBufferSystem b, Log c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5265750", Offset = "0x5264750", VA = "0x185265750", Slot = "4")]
		public bool JVLWNOYTBVP(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5266DA0", Offset = "0x5265DA0", VA = "0x185266DA0", Slot = "5")]
		public bool QRMJDNETMPY(Entity a, object b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5268D00", Offset = "0x5267D00", VA = "0x185268D00", Slot = "6")]
		public bool UXYCQQREGSR(Entity a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5268C50", Offset = "0x5267C50", VA = "0x185268C50", Slot = "8")]
		public bool UXYCQQREGSR(TokenHandle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5265090", Offset = "0x5264090", VA = "0x185265090", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5268F90", Offset = "0x5267F90", VA = "0x185268F90")]
		private void XVJVHKSMNRM(HashSet<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5268680", Offset = "0x5267680", VA = "0x185268680")]
		private bool URKTGHUQTOY(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5267D70", Offset = "0x5266D70", VA = "0x185267D70")]
		private bool TITHTZNNWII(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5266B80", Offset = "0x5265B80", VA = "0x185266B80")]
		private void NPPIFMNBWXV(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5267ED0", Offset = "0x5266ED0", VA = "0x185267ED0")]
		private void TQUOQYZKBCC(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5265190", Offset = "0x5264190", VA = "0x185265190")]
		private void IHIGTVYJKZF(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x52667F0", Offset = "0x52657F0", VA = "0x1852667F0")]
		private void NHFCFYZPIEU(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5264FF0", Offset = "0x5263FF0", VA = "0x185264FF0")]
		private bool CUMTYGPXTHX(TokenHandle a, [Out] HashSet<object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5264C90", Offset = "0x5263C90", VA = "0x185264C90")]
		private HashSet<object> AFPRYDOYTPM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class MQEXJDJBZJN
	{
	}
}
namespace RecRoom.ObjectModel.Mappers
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct Float3GetX : LLSQDRLKKGW<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88E0C70", Offset = "0x88DFC70", VA = "0x1888E0C70")]
		public float OSQFXNPZIYV([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88E0C70", Offset = "0x88DFC70", VA = "0x1888E0C70", Slot = "4")]
		private float WSRSHCXOSPZ([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct Float3GetY : LLSQDRLKKGW<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88E0C80", Offset = "0x88DFC80", VA = "0x1888E0C80")]
		public float OSQFXNPZIYV([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88E0C80", Offset = "0x88DFC80", VA = "0x1888E0C80", Slot = "4")]
		private float WSRSHCXOSPZ([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct Float3GetZ : LLSQDRLKKGW<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88E0C90", Offset = "0x88DFC90", VA = "0x1888E0C90")]
		public float OSQFXNPZIYV([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88E0C90", Offset = "0x88DFC90", VA = "0x1888E0C90", Slot = "4")]
		private float WSRSHCXOSPZ([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct Int3GetX : LLSQDRLKKGW<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x119D9B0", Offset = "0x119C9B0", VA = "0x18119D9B0")]
		public int OSQFXNPZIYV([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x119D9B0", Offset = "0x119C9B0", VA = "0x18119D9B0", Slot = "4")]
		private int BRZEVAPLSKI([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct Int3GetY : LLSQDRLKKGW<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x14C6790", Offset = "0x14C5790", VA = "0x1814C6790")]
		public int OSQFXNPZIYV([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x14C6790", Offset = "0x14C5790", VA = "0x1814C6790", Slot = "4")]
		private int BRZEVAPLSKI([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Int3GetZ : LLSQDRLKKGW<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A70", Offset = "0x10B0A70", VA = "0x1810B1A70")]
		public int OSQFXNPZIYV([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A70", Offset = "0x10B0A70", VA = "0x1810B1A70", Slot = "4")]
		private int BRZEVAPLSKI([In] int3 value)
		{
			return default(int);
		}
	}
}
namespace RecRoom.ObjectModel.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class RegisterComponentSystem : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2E50040", Offset = "0x2E4F040", VA = "0x182E50040")]
		public RegisterComponentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class BUVISOKYVNP : SystemBase, HOIVCNTBDBM
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x88E0B80", Offset = "0x88DFB80", VA = "0x1888E0B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36A5F70", Offset = "0x36A4F70", VA = "0x1836A5F70")]
		public void DSAIIBWUJIR<a>() where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x36A68E0", Offset = "0x36A58E0", VA = "0x1836A68E0")]
		public void JJKYUOWYEIU<b>() where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x36A6AA0", Offset = "0x36A5AA0", VA = "0x1836A6AA0")]
		public JobHandle OETWWFOFMXE<c>() where c : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88E0AB0", Offset = "0x88DFAB0", VA = "0x1888E0AB0")]
		public JobHandle OETWWFOFMXE(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x36A5EE0", Offset = "0x36A4EE0", VA = "0x1836A5EE0")]
		public JobHandle BOVBGZTSYMX<d>() where d : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88E0840", Offset = "0x88DF840", VA = "0x1888E0840")]
		public JobHandle BOVBGZTSYMX(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x36A61E0", Offset = "0x36A51E0", VA = "0x1836A61E0")]
		public void DUCPAVXGAKR<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x36A6120", Offset = "0x36A5120", VA = "0x1836A6120")]
		public JobHandle DUCPAVXGAKR<f>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x88E08F0", Offset = "0x88DF8F0", VA = "0x1888E08F0")]
		public JobHandle DUCPAVXGAKR(ReadOnlySpan<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x36A6C80", Offset = "0x36A5C80", VA = "0x1836A6C80")]
		public void UPSAWCPAZHE<g>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x36A6BC0", Offset = "0x36A5BC0", VA = "0x1836A6BC0")]
		public JobHandle UPSAWCPAZHE<h>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88E0B00", Offset = "0x88DFB00", VA = "0x1888E0B00")]
		public JobHandle UPSAWCPAZHE(Span<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x36A6A10", Offset = "0x36A5A10", VA = "0x1836A6A10")]
		public ComponentDataFromEntity NXZARSRUZIW<i>(bool a = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88E0990", Offset = "0x88DF990", VA = "0x1888E0990")]
		public ComponentDataFromEntity NXZARSRUZIW(int a, bool b = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x36A70D0", Offset = "0x36A60D0", VA = "0x1836A70D0")]
		public SharedComponentIndexFromEntity<j> YGNRDQWXADG<j>() where j : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88E0890", Offset = "0x88DF890", VA = "0x1888E0890")]
		[GenerateTestsForBurstCompatibility]
		public ComponentTypeHandle DRAVPKEQYMA(ComponentType a)
		{
			return default(ComponentTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88E0960", Offset = "0x88DF960", VA = "0x1888E0960")]
		public EntityExistenceLookupByEntity IFWFQIRDDCM()
		{
			return default(EntityExistenceLookupByEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x88E0B70", Offset = "0x88DFB70", VA = "0x1888E0B70", Slot = "10")]
		public sealed override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x36A6830", Offset = "0x36A5830", VA = "0x1836A6830")]
		public bool HCBIADZPRPM<k>()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
		[Preserve]
		protected sealed override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2E50040", Offset = "0x2E4F040", VA = "0x182E50040")]
		[Preserve]
		protected BUVISOKYVNP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class MAXTBAEGBKO : BUVISOKYVNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x88E0EE0", Offset = "0x88DFEE0", VA = "0x1888E0EE0", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2E50040", Offset = "0x2E4F040", VA = "0x182E50040")]
		[Preserve]
		protected MAXTBAEGBKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class HYGCAQYMNKT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class USGDWPXYXRO : EntityCommandBufferSystem, HOIVCNTBDBM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Log YRUBCRKOSIV
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xBDCBA0", Offset = "0xBDBBA0", VA = "0x180BDCBA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x88E1B10", Offset = "0x88E0B10", VA = "0x1888E1B10")]
		public USGDWPXYXRO(Log a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface LLSQDRLKKGW<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b OSQFXNPZIYV([In] a value);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface GNANOYHDSGE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VHJGLTZYSJY(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[BurstCompile]
	internal struct AddComponentECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ComponentTypeSet componentTypes;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88E07C0", Offset = "0x88DF7C0", VA = "0x1888E07C0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[BurstCompile]
	internal struct DestroyEntityECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x88E0BB0", Offset = "0x88DFBB0", VA = "0x1888E0BB0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[BurstCompile]
	internal struct RemoveComponentECB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ComponentType componentType;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88E14A0", Offset = "0x88E04A0", VA = "0x1888E14A0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[BurstCompile]
	internal struct SetComponentECB<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61C3140", Offset = "0x61C2140", VA = "0x1861C3140", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal struct SetSharedComponentArrayECB<T> : IJob where T : struct, ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61C4480", Offset = "0x61C3480", VA = "0x1861C4480", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal struct SetSharedComponentECB<T> : IJob where T : struct, ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Unity.Collections.ReadOnly]
		public T value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61C4640", Offset = "0x61C3640", VA = "0x1861C4640", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[BurstCompile]
	internal struct MapArrayJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, LLSQDRLKKGW<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[WriteOnly]
		public NativeArray<TTo> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5B23380", Offset = "0x5B22380", VA = "0x185B23380", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[BurstCompile]
	internal struct MapEntityToComponentDataArrayJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity srcDataFromEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[WriteOnly]
		public NativeArray<byte> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int typeSize;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x88E0F10", Offset = "0x88DFF10", VA = "0x1888E0F10", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[BurstCompile]
	internal struct MapEntityToComponentDataListJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> dstDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[WriteOnly]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5B23780", Offset = "0x5B22780", VA = "0x185B23780", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal struct MapListJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, LLSQDRLKKGW<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[WriteOnly]
		public NativeList<TTo> dstDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5B31570", Offset = "0x5B30570", VA = "0x185B31570", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[BurstCompile]
	internal struct ReduceAllHaveComponentJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeArray<bool> dstResult;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x609E100", Offset = "0x609D100", VA = "0x18609E100", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct ReduceAnyHasComponentJob<T> : IJob where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Unity.Collections.ReadOnly]
		public ComponentLookup<T> componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeArray<bool> dstResult;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x609E280", Offset = "0x609D280", VA = "0x18609E280", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct ReduceDistinctJob<T> : IJob where T : struct, IEquatable<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeParallelHashSet<T> set;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x609E590", Offset = "0x609D590", VA = "0x18609E590", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[BurstCompile]
	internal struct ReduceDistinctSelectJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : LLSQDRLKKGW<TFrom, TTo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Unity.Collections.ReadOnly]
		public NativeArray<TFrom> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeList<TFrom> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeParallelHashSet<TTo> set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TMap action;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x609E650", Offset = "0x609D650", VA = "0x18609E650", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	internal struct ReduceEntitiesPredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, GNANOYHDSGE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntityArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeList<Entity> dstEntityList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TPredicate action;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x609EB60", Offset = "0x609DB60", VA = "0x18609EB60", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[BurstCompile]
	internal struct ReducePredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, GNANOYHDSGE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Unity.Collections.ReadOnly]
		public NativeArray<T> srcDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeList<T> dstDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TPredicate action;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x609F470", Offset = "0x609E470", VA = "0x18609F470", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	internal struct ReduceWithComponentJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NativeList<Entity> dstEntities;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88E1370", Offset = "0x88E0370", VA = "0x1888E1370", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[BurstCompile]
	internal struct ReduceWithoutComponentJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Unity.Collections.ReadOnly]
		public ComponentDataFromEntity componentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Unity.Collections.ReadOnly]
		public NativeArray<Entity> srcEntities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeList<Entity> dstEntities;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x88E1400", Offset = "0x88E0400", VA = "0x1888E1400", Slot = "4")]
		[IgnoreWarning(1371)]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class PFOXUOSMQDJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class TLUGUTZOZFY
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBC50", Offset = "0x3DDAC50", VA = "0x183DDBC50")]
		public static bool JELVVZPDEIS<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class LIHFDYYALWM
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class OJRPOHUUUNR<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public OJRPOHUUUNR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class UNHLGIPVAKO<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public UNHLGIPVAKO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly List<Func<JobHandle, JobHandle>> RPVDHJIIORT;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88E0E60", Offset = "0x88DFE60", VA = "0x1888E0E60")]
		public LIHFDYYALWM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class GWWZEJHGVKG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class DBCKUFVUZMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct Array<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000038")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000052")]
				internal Array<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal NativeArray<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct List<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				internal List<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal NativeList<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ArrayAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003C")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				internal ArrayAsync<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal NativeArrayAsync<TFrom> src;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public struct ListAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200003E")]
			public struct SKey<TKey> where TKey : struct, IEquatable<TKey>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				internal ListAsync<TFrom> parent;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			internal Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal NativeListAsync<TFrom> src;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class TKEERLPHECJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class RWWPUNJIYPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B5E0", Offset = "0x3D4A5E0", VA = "0x183D4B5E0")]
		public static NativeList<T> ZYSWGJRYCSN<T>(this NativeArray<T> a, Allocator b = Allocator.TempJob) where T : struct, IEquatable<T>
		{
			return default(NativeList<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class BUSHQUJNKAF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class TBGNPYLGKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB880", Offset = "0x3DBA880", VA = "0x183DBB880")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3DBAF30", Offset = "0x3DB9F30", VA = "0x183DBAF30")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArrayAsync<Entity> entities, NativeArrayAsync<T> data, [Optional] JobHandle dependsOn) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3DBADD0", Offset = "0x3DB9DD0", VA = "0x183DBADD0")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88E1520", Offset = "0x88E0520", VA = "0x1888E1520")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88E1680", Offset = "0x88E0680", VA = "0x1888E1680")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, EntityCommandBuffer ecb, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class GHVNBKEILXG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class TTBFXWQAHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x88E17F0", Offset = "0x88E07F0", VA = "0x1888E17F0")]
		[MustUseReturnValue]
		public static JobHandle JVSZSLMZUWK(this EntityCommandBufferSystem a, NativeList<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x88E1970", Offset = "0x88E0970", VA = "0x1888E1970")]
		[MustUseReturnValue]
		public static JobHandle JVSZSLMZUWK(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class OAVLYJZFQQU
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3B89AC0", Offset = "0x3B88AC0", VA = "0x183B89AC0")]
		public static void LXKMGYHTTHO<a>(this EntityCommandBufferSystem a, EntityQuery b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3B89900", Offset = "0x3B88900", VA = "0x183B89900")]
		[MustUseReturnValue]
		public static JobHandle DJQDAYMSXBG<e>(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x88E1090", Offset = "0x88E0090", VA = "0x1888E1090")]
		[MustUseReturnValue]
		public static JobHandle DJQDAYMSXBG(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, ComponentType c, [Optional] JobHandle d)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class XEMUJTHDCDY
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FEF0", Offset = "0x3F4EEF0", VA = "0x183F4FEF0")]
		[MustUseReturnValue]
		public static JobHandle REMAHVMKDFE<T>(this EntityCommandBufferSystem a, NativeArray<Entity> b, NativeArray<T> c, JobHandle d) where T : struct, IComponentData
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class TTQNQBABELR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class GXADWAJYZCM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class JXVVNZTOMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3A1B400", Offset = "0x3A1A400", VA = "0x183A1B400")]
		public static NativeArray<a> ZNNHECHQOWT<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where a : struct, IComponentData
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3A1B5A0", Offset = "0x3A1A5A0", VA = "0x183A1B5A0")]
		public static NativeArray<b> ZNNHECHQOWT<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where b : struct, IComponentData
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x88E0CA0", Offset = "0x88DFCA0", VA = "0x1888E0CA0")]
		public static NativeArray<Entity> TTKHLGMQAIM(this NativeArray<Entity> a, EntityManager b, ComponentType c, Allocator d = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3A1B080", Offset = "0x3A1A080", VA = "0x183A1B080")]
		public static NativeArray<T> KYRRGGUGGMA<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class IJOQZCIZWKP
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct Array<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public Array<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public NativeArray<TFrom> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct ArrayAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x200004E")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				public ArrayAsync<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public NativeArrayAsync<TFrom> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct ListAsync<TFrom> where TFrom : struct
		{
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			public struct SKey<TTo> where TTo : struct
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public ListAsync<TFrom> src;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public NativeListAsync<TFrom> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class BJGGFKLJNCH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class TLPQMAZFLQH
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct RemapEntitiesAction : LLSQDRLKKGW<Entity, Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[Unity.Collections.ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x88E1490", Offset = "0x88E0490", VA = "0x1888E1490")]
			[GenerateTestsForBurstCompatibility]
			public Entity OSQFXNPZIYV([In] Entity value)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x88E1490", Offset = "0x88E0490", VA = "0x1888E1490", Slot = "4")]
			private Entity VGAAFLLOAXY([In] Entity value)
			{
				return default(Entity);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class WZFBBXZDFIM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private struct Comparer<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x43BAF60", Offset = "0x43B9F60", VA = "0x1843BAF60", Slot = "4")]
			public int Compare((TKey, TValue) x, (TKey, TValue) y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C4F0", Offset = "0x3F3B4F0", VA = "0x183F3C4F0")]
		public static void Sort<TKey, TValue>(NativeList<TKey> keys, NativeList<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C310", Offset = "0x3F3B310", VA = "0x183F3C310")]
		public static void Sort<TKey, TValue>(NativeArray<TKey> keys, NativeArray<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DBF0", Offset = "0x3F3CBF0", VA = "0x183F3DBF0")]
		public static void Sort<TKey, TValue, U>(NativeArray<TKey> keys, NativeArray<TValue> values, U comparer) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class ORUREDRFVBI
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct Array<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public NativeArray<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct List<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public NativeList<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct ArrayAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public NativeArrayAsync<Entity> srcEntityArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public NativeArrayAsync<T> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class LHSVBUILDGM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class CTVAOJCQCXI
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public struct Array<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public NativeArray<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct List<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NativeList<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct ArrayAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public NativeArrayAsync<T> srcDataArray;
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct ListAsync<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Allocator allocator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public NativeListAsync<T> srcDataArray;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class TVOIDNYABFO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class LEXICODVJTO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AE10", Offset = "0x3A59E10", VA = "0x183A5AE10")]
		public static NativeList<Entity> ZMIHNBBFVFC<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A9B0", Offset = "0x3A599B0", VA = "0x183A5A9B0")]
		public static NativeList<Entity> ZMIHNBBFVFC<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class OUZNUSFZBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E400", Offset = "0x3B8D400", VA = "0x183B8E400")]
		public static NativeList<Entity> GKSWCKNAURQ<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class IQAGJRQXFEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public readonly struct EnumerateHelper<TSrc> where TSrc : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public readonly struct SelectTypeEnumerateHelper<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public readonly struct SelectedTypeEnumerateHelper<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, LLSQDRLKKGW<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public struct SelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, LLSQDRLKKGW<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private readonly NativeArray<TSrc> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TSelector selector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int index;
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public struct GroupedSelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, LLSQDRLKKGW<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private SelectedTypeEnumerator<TSrc, TValue, TSelector> enumerator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private TValue startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private int startIndex;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class GWMDSWTOHSA
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct GroupedEnumerator<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly NativeArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int currIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private T startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private T currValue;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public RecRoom.Foundation.Collections.Range LZXEEAIMYLN
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x5258D20", Offset = "0x5257D20", VA = "0x185258D20")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public T GQWOMIPIDFB
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public (T, RecRoom.Foundation.Collections.Range) NHMTQMXSIMG
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x5257DC0", Offset = "0x5256DC0", VA = "0x185257DC0")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5258DD0", Offset = "0x5257DD0", VA = "0x185258DD0")]
			public GroupedEnumerator(NativeArray<T> array)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4423220", Offset = "0x4422220", VA = "0x184423220")]
			public GroupedEnumerator<T> GetEnumerator()
			{
				return default(GroupedEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5258370", Offset = "0x5257370", VA = "0x185258370")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3C73240", Offset = "0x3C72240", VA = "0x183C73240")]
			public GroupedWithComparerEnumerator<T, a> ERRBGBZVWTS<a>([Optional] a a) where a : struct, IEqualityComparer<T>
			{
				return default(GroupedWithComparerEnumerator<T, a>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct GroupedWithComparerEnumerator<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private readonly NativeArray<T> array;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int startIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private int currIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private T startValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private T currValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TComparer comparer;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public RecRoom.Foundation.Collections.Range LZXEEAIMYLN
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x5258D20", Offset = "0x5257D20", VA = "0x185258D20")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public T GQWOMIPIDFB
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public (T value, RecRoom.Foundation.Collections.Range range) NHMTQMXSIMG
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x5259540", Offset = "0x5258540", VA = "0x185259540")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x525A300", Offset = "0x5259300", VA = "0x18525A300")]
			public GroupedWithComparerEnumerator(NativeArray<T> array, TComparer comparer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4430F30", Offset = "0x442FF30", VA = "0x184430F30")]
			public GroupedWithComparerEnumerator<T, TComparer> GetEnumerator()
			{
				return default(GroupedWithComparerEnumerator<T, TComparer>);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5259DC0", Offset = "0x5258DC0", VA = "0x185259DC0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x39A06A0", Offset = "0x399F6A0", VA = "0x1839A06A0")]
		public static GroupedEnumerator<T> Group<T>(this NativeArray<T> array) where T : struct
		{
			return default(GroupedEnumerator<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct ProtobufMessageListDeserializer<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class PAGXHFRYZEK : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private (int index, Protobuf element) IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public ProtobufMessageListDeserializer<Protobuf> FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private int GLLQGAOFNOJ;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private (int, Protobuf) YRYNMWVOXXD
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x51CA670", Offset = "0x51C9670", VA = "0x1851CA670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default((int, Protobuf));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x51CA760", Offset = "0x51C9760", VA = "0x1851CA760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x41A5260", Offset = "0x41A4260", VA = "0x1841A5260")]
			[DebuggerHidden]
			public PAGXHFRYZEK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5D85FF0", Offset = "0x5D84FF0", VA = "0x185D85FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x405A760", Offset = "0x4059760", VA = "0x18405A760", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Action<Protobuf> resetToDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly CodedInputStream inputStream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Protobuf element;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5E1EE50", Offset = "0x5E1DE50", VA = "0x185E1EE50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EBE0", Offset = "0x5E1DBE0", VA = "0x185E1EBE0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EC90", Offset = "0x5E1DC90", VA = "0x185E1EC90", Slot = "4")]
		[IteratorStateMachine(typeof(ProtobufMessageListDeserializer<>.PAGXHFRYZEK))]
		public IEnumerator<(int, Protobuf)> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EE00", Offset = "0x5E1DE00", VA = "0x185E1EE00", Slot = "5")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct ProtobufMessageListSerializer<Protobuf> : IDisposable where Protobuf : IMessage, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Protobuf element;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CodedOutputStream outputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EEA0", Offset = "0x5E1DEA0", VA = "0x185E1EEA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct ProtobufRawListDeserializer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CodedInputStream inputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x88E1200", Offset = "0x88E0200", VA = "0x1888E1200", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct ProtobufRawListSerializer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly MemoryStream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CodedOutputStream outputStream;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x88E1240", Offset = "0x88E0240", VA = "0x1888E1240", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class WGZZMFQZRNW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class FDKAKUXFXNP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Flags]
	public enum RRWorldFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Live = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Editor = 3,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Main = 5,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Simulation = 9,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Conversion = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Staging = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Shadow = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Loading = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Saving = 0x100
	}
}
namespace RecRoom.ObjectModel.Entities.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class ANFBHJCYAAC
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal class ISTPLHFHRIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__495080977
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x88E1B50", Offset = "0x88E0B50", VA = "0x1888E1B50")]
	public static void YCMHZVKAXHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x88E1B40", Offset = "0x88E0B40", VA = "0x1888E1B40")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
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

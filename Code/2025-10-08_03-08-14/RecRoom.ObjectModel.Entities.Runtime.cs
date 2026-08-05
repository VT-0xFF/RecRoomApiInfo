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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8748080", Offset = "0x8746E80", VA = "0x188748080")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MUPXUODILAN
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
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MUPXUODILAN()
	{
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8747BD0", Offset = "0x87469D0", VA = "0x188747BD0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface LVCLPPVLJOM : IComponentData
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
	public interface NQBHVXZMDTG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KQGHLXMMAUP(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SUEOKOSSLRC(Entity a, object b, [Out] bool c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool GOLCAOHIHAX(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class EWWBDIESPKD<a, b> : VXYMFWYNMKL<b>, IDisposable where a : struct, LVCLPPVLJOM
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class ZANHRTQBUWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private List<(object token, b value)> JBNEROFCSEP;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int ODIIXCYNYBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x2936F90", Offset = "0x2935D90", VA = "0x182936F90")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x410B090", Offset = "0x4109E90", VA = "0x18410B090")]
			public bool CAWWBDMWMDW([Out] b a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x410AEE0", Offset = "0x4109CE0", VA = "0x18410AEE0")]
			public void Add(object token, b value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x410B5A0", Offset = "0x410A3A0", VA = "0x18410B5A0")]
			public bool Remove(object token)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x410B2F0", Offset = "0x410A0F0", VA = "0x18410B2F0")]
			public int CEFOTAJSKFG(object a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x410B670", Offset = "0x410A470", VA = "0x18410B670")]
			public ZANHRTQBUWU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Stack<ZANHRTQBUWU> UEEXZTTPPMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ManagedObjectPool<TokenHandle, ZANHRTQBUWU> HSMOMCXWUIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private EntityManager QJRCXHAJSZV;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CE60", Offset = "0x4A5BC60", VA = "0x184A5CE60")]
		public EWWBDIESPKD(EntityManager a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4A5BEC0", Offset = "0x4A5ACC0", VA = "0x184A5BEC0", Slot = "4")]
		public void KQGHLXMMAUP(Entity a, object b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4A5C840", Offset = "0x4A5B640", VA = "0x184A5C840", Slot = "5")]
		public bool SUEOKOSSLRC(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4A5BA40", Offset = "0x4A5A840", VA = "0x184A5BA40", Slot = "6")]
		public bool CAWWBDMWMDW(Entity a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4A5BCF0", Offset = "0x4A5AAF0", VA = "0x184A5BCF0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CC90", Offset = "0x4A5BA90", VA = "0x184A5CC90")]
		private void ZEQZNETBPFW(ZANHRTQBUWU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CA30", Offset = "0x4A5B830", VA = "0x184A5CA30")]
		private bool TUUFYUACBTI(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4A5C560", Offset = "0x4A5B360", VA = "0x184A5C560")]
		private void NWCNODKINUS(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4A5BC70", Offset = "0x4A5AA70", VA = "0x184A5BC70")]
		private bool CIBHONSBWOA(TokenHandle a, [Out] ZANHRTQBUWU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4A5BD30", Offset = "0x4A5AB30", VA = "0x184A5BD30")]
		private ZANHRTQBUWU JQYPSRDXPVW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface VXYMFWYNMKL<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KQGHLXMMAUP(Entity a, object b, a c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SUEOKOSSLRC(Entity a, object b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CAWWBDMWMDW(Entity a, [Out] a b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct TokenHandle : VJTUBMNJJFG, IEquatable<TokenHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly TokenHandle Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x30206B0", Offset = "0x301F4B0", VA = "0x1830206B0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x30206C0", Offset = "0x301F4C0", VA = "0x1830206C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8748830", Offset = "0x8747630", VA = "0x188748830", Slot = "8")]
		public bool Equals(TokenHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8748880", Offset = "0x8747680", VA = "0x188748880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class HNYBBMJSXCO<a> : NQBHVXZMDTG, IDisposable where a : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Entity, TokenHandle> WYGPUSLPCWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Stack<HashSet<object>> UEEXZTTPPMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ManagedObjectPool<TokenHandle, HashSet<object>> HSMOMCXWUIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EntityManager QJRCXHAJSZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private EntityCommandBufferSystem OIZIABMLFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool IYRJDGYKKCM;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5207220", Offset = "0x5206020", VA = "0x185207220")]
		public HNYBBMJSXCO(EntityManager a, EntityCommandBufferSystem b, Log c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5204460", Offset = "0x5203260", VA = "0x185204460", Slot = "4")]
		public bool KQGHLXMMAUP(Entity a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5206020", Offset = "0x5204E20", VA = "0x185206020", Slot = "5")]
		public bool SUEOKOSSLRC(Entity a, object b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5203BC0", Offset = "0x52029C0", VA = "0x185203BC0", Slot = "6")]
		public bool GOLCAOHIHAX(Entity a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5203A60", Offset = "0x5202860", VA = "0x185203A60", Slot = "8")]
		public bool GOLCAOHIHAX(TokenHandle a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x52036B0", Offset = "0x52024B0", VA = "0x1852036B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5206FE0", Offset = "0x5205DE0", VA = "0x185206FE0")]
		private void ZEQZNETBPFW(HashSet<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5206D10", Offset = "0x5205B10", VA = "0x185206D10")]
		private bool TUUFYUACBTI(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5203320", Offset = "0x5202120", VA = "0x185203320")]
		private bool CMHRWUUKJEK(Entity a, [Out] TokenHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5202E30", Offset = "0x5201C30", VA = "0x185202E30")]
		private void BUCTJUCPRVH(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5205420", Offset = "0x5204220", VA = "0x185205420")]
		private void MJHQIVBEIEE(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5205760", Offset = "0x5204560", VA = "0x185205760")]
		private void PYWHZHCYVXD(Entity a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5205680", Offset = "0x5204480", VA = "0x185205680")]
		private void NWCNODKINUS(Entity a, TokenHandle b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5203550", Offset = "0x5202350", VA = "0x185203550")]
		private bool DBXPOTXAQEP(TokenHandle a, [Out] HashSet<object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5203DF0", Offset = "0x5202BF0", VA = "0x185203DF0")]
		private HashSet<object> JQYPSRDXPVW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class LRBTANQTQUJ
	{
	}
}
namespace RecRoom.ObjectModel.Mappers
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct Float3GetX : BLIJCDUNJKQ<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8747BF0", Offset = "0x87469F0", VA = "0x188747BF0")]
		public float IVBAMHNSTCX([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8747BF0", Offset = "0x87469F0", VA = "0x188747BF0", Slot = "4")]
		private float IKVCJLXPOVP([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct Float3GetY : BLIJCDUNJKQ<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8747C00", Offset = "0x8746A00", VA = "0x188747C00")]
		public float IVBAMHNSTCX([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8747C00", Offset = "0x8746A00", VA = "0x188747C00", Slot = "4")]
		private float IKVCJLXPOVP([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct Float3GetZ : BLIJCDUNJKQ<float3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8747C10", Offset = "0x8746A10", VA = "0x188747C10")]
		public float IVBAMHNSTCX([In] float3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8747C10", Offset = "0x8746A10", VA = "0x188747C10", Slot = "4")]
		private float IKVCJLXPOVP([In] float3 value)
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct Int3GetX : BLIJCDUNJKQ<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x148DAD0", Offset = "0x148C8D0", VA = "0x18148DAD0")]
		public int IVBAMHNSTCX([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x148DAD0", Offset = "0x148C8D0", VA = "0x18148DAD0", Slot = "4")]
		private int ZJFRFKIFMXY([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct Int3GetY : BLIJCDUNJKQ<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1401360", Offset = "0x1400160", VA = "0x181401360")]
		public int IVBAMHNSTCX([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1401360", Offset = "0x1400160", VA = "0x181401360", Slot = "4")]
		private int ZJFRFKIFMXY([In] int3 value)
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Int3GetZ : BLIJCDUNJKQ<int3, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xFEA5A0", Offset = "0xFE93A0", VA = "0x180FEA5A0")]
		public int IVBAMHNSTCX([In] int3 value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xFEA5A0", Offset = "0xFE93A0", VA = "0x180FEA5A0", Slot = "4")]
		private int ZJFRFKIFMXY([In] int3 value)
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
		[Cpp2IlInjected.Address(RVA = "0x2DBDFE0", Offset = "0x2DBCDE0", VA = "0x182DBDFE0")]
		public RegisterComponentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class PJKQADIYLUH : SystemBase, CRBWQEVUHJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8748400", Offset = "0x8747200", VA = "0x188748400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D2A0", Offset = "0x3B1C0A0", VA = "0x183B1D2A0")]
		public void IPSTVGAHJVJ<a>() where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D910", Offset = "0x3B1C710", VA = "0x183B1D910")]
		public void QNGMLCHQKAO<b>() where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CB70", Offset = "0x3B1B970", VA = "0x183B1CB70")]
		public JobHandle AMAUJLDKAMQ<c>() where c : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8748180", Offset = "0x8746F80", VA = "0x188748180")]
		public JobHandle AMAUJLDKAMQ(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DC00", Offset = "0x3B1CA00", VA = "0x183B1DC00")]
		public JobHandle TQVXRQQKMDL<d>() where d : struct
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8748430", Offset = "0x8747230", VA = "0x188748430")]
		public JobHandle TQVXRQQKMDL(ReadOnlySpan<TypeIndex> a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CEB0", Offset = "0x3B1BCB0", VA = "0x183B1CEB0")]
		public void HVAFOGKHYTJ<e>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CDF0", Offset = "0x3B1BBF0", VA = "0x183B1CDF0")]
		public JobHandle HVAFOGKHYTJ<f>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8748200", Offset = "0x8747000", VA = "0x188748200")]
		public JobHandle HVAFOGKHYTJ(ReadOnlySpan<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D480", Offset = "0x3B1C280", VA = "0x183B1D480")]
		public void JYPROJDSRIQ<g>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D3C0", Offset = "0x3B1C1C0", VA = "0x183B1D3C0")]
		public JobHandle JYPROJDSRIQ<h>(JobHandle a)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8748270", Offset = "0x8747070", VA = "0x188748270")]
		public JobHandle JYPROJDSRIQ(Span<TypeIndex> a, JobHandle b)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D880", Offset = "0x3B1C680", VA = "0x183B1D880")]
		public ComponentDataFromEntity NBZDEAVLRNG<i>(bool a = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x87482E0", Offset = "0x87470E0", VA = "0x1887482E0")]
		public ComponentDataFromEntity NBZDEAVLRNG(int a, bool b = false)
		{
			return default(ComponentDataFromEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DA90", Offset = "0x3B1C890", VA = "0x183B1DA90")]
		public SharedComponentIndexFromEntity<j> RHUXFHWWBTY<j>() where j : ISharedComponentData
		{
			return default(SharedComponentIndexFromEntity<j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8748490", Offset = "0x8747290", VA = "0x188748490")]
		[GenerateTestsForBurstCompatibility]
		public ComponentTypeHandle XRVDFPSLRNM(ComponentType a)
		{
			return default(ComponentTypeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x87481D0", Offset = "0x8746FD0", VA = "0x1887481D0")]
		public EntityExistenceLookupByEntity BDYIRKNHASO()
		{
			return default(EntityExistenceLookupByEntity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8748480", Offset = "0x8747280", VA = "0x188748480", Slot = "10")]
		public sealed override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CD40", Offset = "0x3B1BB40", VA = "0x183B1CD40")]
		public bool GJUGYOTWHSE<k>()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
		[Preserve]
		protected sealed override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2DBDFE0", Offset = "0x2DBCDE0", VA = "0x182DBDFE0")]
		[Preserve]
		protected PJKQADIYLUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class QVKLPIGWCOE : PJKQADIYLUH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8748650", Offset = "0x8747450", VA = "0x188748650", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2DBDFE0", Offset = "0x2DBCDE0", VA = "0x182DBDFE0")]
		[Preserve]
		protected QVKLPIGWCOE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class RPYKPIFABBD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class NWYYMKNQRDM : EntityCommandBufferSystem, CRBWQEVUHJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Log WPIOOUTTKAH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB3EC20", Offset = "0xB3DA20", VA = "0x180B3EC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8748050", Offset = "0x8746E50", VA = "0x188748050")]
		public NWYYMKNQRDM(Log a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface BLIJCDUNJKQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b IVBAMHNSTCX([In] a value);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface JBLJGZPXERQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AAEKKNGNHOE(a a);
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
		[Cpp2IlInjected.Address(RVA = "0x8747AB0", Offset = "0x87468B0", VA = "0x188747AB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8747B30", Offset = "0x8746930", VA = "0x188747B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x87487B0", Offset = "0x87475B0", VA = "0x1887487B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x61463F0", Offset = "0x61451F0", VA = "0x1861463F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6147700", Offset = "0x6146500", VA = "0x186147700", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x61478C0", Offset = "0x61466C0", VA = "0x1861478C0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[BurstCompile]
	internal struct MapArrayJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BLIJCDUNJKQ<TFrom, TTo>
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
		[Cpp2IlInjected.Address(RVA = "0x5AADBE0", Offset = "0x5AAC9E0", VA = "0x185AADBE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8747F50", Offset = "0x8746D50", VA = "0x188747F50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5AADFE0", Offset = "0x5AACDE0", VA = "0x185AADFE0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[BurstCompile]
	internal struct MapListJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BLIJCDUNJKQ<TFrom, TTo>
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
		[Cpp2IlInjected.Address(RVA = "0x5ABD0A0", Offset = "0x5ABBEA0", VA = "0x185ABD0A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6073850", Offset = "0x6072650", VA = "0x186073850", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x60739D0", Offset = "0x60727D0", VA = "0x1860739D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6073CE0", Offset = "0x6072AE0", VA = "0x186073CE0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[BurstCompile]
	internal struct ReduceDistinctSelectJob<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : BLIJCDUNJKQ<TFrom, TTo>
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
		[Cpp2IlInjected.Address(RVA = "0x6073DA0", Offset = "0x6072BA0", VA = "0x186073DA0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	internal struct ReduceEntitiesPredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, JBLJGZPXERQ<T>
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
		[Cpp2IlInjected.Address(RVA = "0x60742A0", Offset = "0x60730A0", VA = "0x1860742A0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[BurstCompile]
	internal struct ReducePredicateJob<T, TPredicate> : IJob where T : struct where TPredicate : struct, JBLJGZPXERQ<T>
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
		[Cpp2IlInjected.Address(RVA = "0x6074B70", Offset = "0x6073970", VA = "0x186074B70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8748680", Offset = "0x8747480", VA = "0x188748680", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8748710", Offset = "0x8747510", VA = "0x188748710", Slot = "4")]
		[IgnoreWarning(1371)]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class AXZMAPBMOXD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class AJJEWLKUEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3270A60", Offset = "0x326F860", VA = "0x183270A60")]
		public static bool WZMJVCZLKWI<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, IComponentData
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class OZJQGFDNCRY
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class SQTKEGTTCEN<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public SQTKEGTTCEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class PALYBJDNTMM<a> where a : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public PALYBJDNTMM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly List<Func<JobHandle, JobHandle>> UOVFWLVDSEP;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8748100", Offset = "0x8746F00", VA = "0x188748100")]
		public OZJQGFDNCRY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class VMJCNOXSHDG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class YCQXBEUISJR
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
	public static class FGXLFGHKZJJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class IUCKVIYVUJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3996710", Offset = "0x3995510", VA = "0x183996710")]
		public static NativeList<T> PFKOALDHAWH<T>(this NativeArray<T> a, Allocator b = Allocator.TempJob) where T : struct, IEquatable<T>
		{
			return default(NativeList<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class AILELPPSFHV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class XQHHUKECTEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3E96E50", Offset = "0x3E95C50", VA = "0x183E96E50")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, NativeArray<T> data) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3E96500", Offset = "0x3E95300", VA = "0x183E96500")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArrayAsync<Entity> entities, NativeArrayAsync<T> data, [Optional] JobHandle dependsOn) where T : struct, IComponentData
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3E96710", Offset = "0x3E95510", VA = "0x183E96710")]
		[MustUseReturnValue]
		public static JobHandle AddComponent<T>(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8748B50", Offset = "0x8747950", VA = "0x188748B50")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8748CB0", Offset = "0x8747AB0", VA = "0x188748CB0")]
		[MustUseReturnValue]
		public static JobHandle AddComponent(this EntityCommandBufferSystem ecbs, EntityCommandBuffer ecb, NativeArray<Entity> entities, ComponentTypeSet componentTypes, [Optional] JobHandle dependsOn)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class SSZWMTMQQPQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class WBIIBOHOLXW
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x87488D0", Offset = "0x87476D0", VA = "0x1887488D0")]
		[MustUseReturnValue]
		public static JobHandle JCSLEDEWLJK(this EntityCommandBufferSystem a, NativeList<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8748A50", Offset = "0x8747850", VA = "0x188748A50")]
		[MustUseReturnValue]
		public static JobHandle JCSLEDEWLJK(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class MSVFMOLXNPQ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3A31700", Offset = "0x3A30500", VA = "0x183A31700")]
		public static void KVKAEWAGTQC<a>(this EntityCommandBufferSystem a, EntityQuery b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3A31940", Offset = "0x3A30740", VA = "0x183A31940")]
		[MustUseReturnValue]
		public static JobHandle RFGQEREYKZE<e>(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, [Optional] JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8747DE0", Offset = "0x8746BE0", VA = "0x188747DE0")]
		[MustUseReturnValue]
		public static JobHandle RFGQEREYKZE(this EntityCommandBufferSystem a, NativeArrayAsync<Entity> b, ComponentType c, [Optional] JobHandle d)
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class YJNUXLBTHTO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0E60", Offset = "0x3E9FC60", VA = "0x183EA0E60")]
		[MustUseReturnValue]
		public static JobHandle FHQNFBLMWMI<T>(this EntityCommandBufferSystem a, NativeArray<Entity> b, NativeArray<T> c, JobHandle d) where T : struct, IComponentData
		{
			return default(JobHandle);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class RDSYUGLNBDH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class IFMLJLSXJHY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class MFYDCLXJGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D020", Offset = "0x3A2BE20", VA = "0x183A2D020")]
		public static NativeArray<a> JGIQMCERJTX<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where a : struct, IComponentData
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D1C0", Offset = "0x3A2BFC0", VA = "0x183A2D1C0")]
		public static NativeArray<b> JGIQMCERJTX<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where b : struct, IComponentData
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8747C20", Offset = "0x8746A20", VA = "0x188747C20")]
		public static NativeArray<Entity> XEJHJWZPLOO(this NativeArray<Entity> a, EntityManager b, ComponentType c, Allocator d = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3A2DB60", Offset = "0x3A2C960", VA = "0x183A2DB60")]
		public static NativeArray<T> KVDINJBSJVM<T>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob) where T : struct, ISharedComponentData
		{
			return default(NativeArray<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class MKERMSBXATX
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
	public static class TSFUFSWDTAR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class ETVPYOXKLOR
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct RemapEntitiesAction : BLIJCDUNJKQ<Entity, Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[Unity.Collections.ReadOnly]
			public NativeArray<EntityRemapUtility.EntityRemapInfo> entityRemapping;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x87487A0", Offset = "0x87475A0", VA = "0x1887487A0")]
			[GenerateTestsForBurstCompatibility]
			public Entity IVBAMHNSTCX([In] Entity value)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x87487A0", Offset = "0x87475A0", VA = "0x1887487A0", Slot = "4")]
			private Entity PMFEEGOLKKY([In] Entity value)
			{
				return default(Entity);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class PXEVLFUVKQO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private struct Comparer<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x42750C0", Offset = "0x4273EC0", VA = "0x1842750C0", Slot = "4")]
			public int Compare((TKey, TValue) x, (TKey, TValue) y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3B21160", Offset = "0x3B1FF60", VA = "0x183B21160")]
		public static void Sort<TKey, TValue>(NativeList<TKey> keys, NativeList<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3B20F80", Offset = "0x3B1FD80", VA = "0x183B20F80")]
		public static void Sort<TKey, TValue>(NativeArray<TKey> keys, NativeArray<TValue> values) where TKey : struct, IComparable<TKey> where TValue : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3B22850", Offset = "0x3B21650", VA = "0x183B22850")]
		public static void Sort<TKey, TValue, U>(NativeArray<TKey> keys, NativeArray<TValue> values, U comparer) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class XCWHULDMJFC
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
	public static class TLGUTGTGNUO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class NVAFOYCMFKA
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
	public static class ZULKGXMQRYW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class KTQCKUVXNXM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x39EB2B0", Offset = "0x39EA0B0", VA = "0x1839EB2B0")]
		public static NativeList<Entity> IUOCXLKBAZI<a>(this NativeList<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x39EAD10", Offset = "0x39E9B10", VA = "0x1839EAD10")]
		public static NativeList<Entity> IUOCXLKBAZI<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class KAUIPOJJHDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x39E2F50", Offset = "0x39E1D50", VA = "0x1839E2F50")]
		public static NativeList<Entity> ADWANNSAZPC<b>(this NativeArray<Entity> a, EntityManager b, Allocator c = Allocator.TempJob)
		{
			return default(NativeList<Entity>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class NKMHUPQQSOV
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
		public readonly struct SelectedTypeEnumerateHelper<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BLIJCDUNJKQ<TSrc, TValue>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private readonly NativeArray<TSrc> array;
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public struct SelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, BLIJCDUNJKQ<TSrc, TValue>
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
		public struct GroupedSelectedTypeEnumerator<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BLIJCDUNJKQ<TSrc, TValue>
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
	public static class GWHTUJBRBMW
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
			public RecRoom.Foundation.Collections.Range CNQOEOCMSPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x51D6E20", Offset = "0x51D5C20", VA = "0x1851D6E20")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public T HUKWPROAXPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public (T, RecRoom.Foundation.Collections.Range) ZJUSDRVWEMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x51D70E0", Offset = "0x51D5EE0", VA = "0x1851D70E0")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x51D7310", Offset = "0x51D6110", VA = "0x1851D7310")]
			public GroupedEnumerator(NativeArray<T> array)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x42DC540", Offset = "0x42DB340", VA = "0x1842DC540")]
			public GroupedEnumerator<T> GetEnumerator()
			{
				return default(GroupedEnumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x51D6410", Offset = "0x51D5210", VA = "0x1851D6410")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3A19A70", Offset = "0x3A18870", VA = "0x183A19A70")]
			public GroupedWithComparerEnumerator<T, a> QQTJPGPMZBA<a>([Optional] a a) where a : struct, IEqualityComparer<T>
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
			public RecRoom.Foundation.Collections.Range CNQOEOCMSPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x51D6E20", Offset = "0x51D5C20", VA = "0x1851D6E20")]
				get
				{
					return default(RecRoom.Foundation.Collections.Range);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public T HUKWPROAXPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public (T value, RecRoom.Foundation.Collections.Range range) ZJUSDRVWEMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x51D82C0", Offset = "0x51D70C0", VA = "0x1851D82C0")]
				get
				{
					return default((T, RecRoom.Foundation.Collections.Range));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x51D8780", Offset = "0x51D7580", VA = "0x1851D8780")]
			public GroupedWithComparerEnumerator(NativeArray<T> array, TComparer comparer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x42E9680", Offset = "0x42E8480", VA = "0x1842E9680")]
			public GroupedWithComparerEnumerator<T, TComparer> GetEnumerator()
			{
				return default(GroupedWithComparerEnumerator<T, TComparer>);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x51D77C0", Offset = "0x51D65C0", VA = "0x1851D77C0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3913800", Offset = "0x3912600", VA = "0x183913800")]
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
		private sealed class IIVFZOGMQQE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private (int index, Protobuf element) QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public ProtobufMessageListDeserializer<Protobuf> WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private int ZTWVKUQIWZR;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private (int, Protobuf) ZLOQHLAYXPV
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x5144110", Offset = "0x5142F10", VA = "0x185144110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default((int, Protobuf));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x51441C0", Offset = "0x5142FC0", VA = "0x1851441C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x42F5D60", Offset = "0x42F4B60", VA = "0x1842F5D60")]
			[DebuggerHidden]
			public IIVFZOGMQQE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x52D86E0", Offset = "0x52D74E0", VA = "0x1852D86E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
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
			[Cpp2IlInjected.Address(RVA = "0x5DD3C40", Offset = "0x5DD2A40", VA = "0x185DD3C40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD39E0", Offset = "0x5DD27E0", VA = "0x185DD39E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3A80", Offset = "0x5DD2880", VA = "0x185DD3A80", Slot = "4")]
		[IteratorStateMachine(typeof(ProtobufMessageListDeserializer<>.IIVFZOGMQQE))]
		public IEnumerator<(int, Protobuf)> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3BF0", Offset = "0x5DD29F0", VA = "0x185DD3BF0", Slot = "5")]
		private IEnumerator UYQUPSIMXFE()
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
		[Cpp2IlInjected.Address(RVA = "0x5DD3C80", Offset = "0x5DD2A80", VA = "0x185DD3C80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x87484F0", Offset = "0x87472F0", VA = "0x1887484F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8748530", Offset = "0x8747330", VA = "0x188748530", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class KJLJUPPILJU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class GNAYBSHDEMP
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
	internal static class ARGWXZOLYPC
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[BurstCompile]
internal class GOJGHSYTRZQ
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3395786535
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8748E30", Offset = "0x8747C30", VA = "0x188748E30")]
	public static void HLHXEDCBNRB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8748E20", Offset = "0x8747C20", VA = "0x188748E20")]
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

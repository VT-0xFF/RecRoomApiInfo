using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class DependsOn : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DependsOn()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public class InitServiceAfter : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Type PriorService
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
		public InitServiceAfter(Type prior)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
	[Obfuscation(Exclude = true, ApplyToMembers = false)]
	public abstract class RegisterType : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		protected RegisterType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public class AlsoBindServiceAs : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Type BindType
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
		public AlsoBindServiceAs(Type bindType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Method)]
	public class CleanupBetweenRooms : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public CleanupBetweenRooms()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class RegisterService : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Type BindType
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7314290", Offset = "0x7313690", VA = "0x187314290")]
		public RegisterService(Type bindType, params string[] categories)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public class ServiceLifetime : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Lifetime Lifetime
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0")]
			[CompilerGenerated]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF8210", Offset = "0x1FF7610", VA = "0x181FF8210")]
		public ServiceLifetime(Lifetime lifetime)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public class SystemEnabledLifetimeAttribute : PreserveAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Lifetime Lifetime
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0")]
			[CompilerGenerated]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1FF8210", Offset = "0x1FF7610", VA = "0x181FF8210")]
		public SystemEnabledLifetimeAttribute(Lifetime lifetime)
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum Lifetime
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Uninitialized = -1,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Application,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		LoginSession,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		PhotonRoom,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		OMRoom,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		LoadInstance,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		COUNT
	}
}
namespace RecRoom.Analyzers
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	public sealed class NullCheckWithIsNullOrDestroyedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public NullCheckWithIsNullOrDestroyedAttribute()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[AttributeUsage(AttributeTargets.Field)]
	public class Config : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68DE2A0", Offset = "0x68DD6A0", VA = "0x1868DE2A0")]
		public Config([Optional] string friendlyName, int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field, AllowMultiple = false)]
	public class ConfigGroupAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77A0730", Offset = "0x779FB30", VA = "0x1877A0730")]
		public ConfigGroupAttribute(string group, int priority = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
	public class ConfigIgnore : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public ConfigIgnore()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[AttributeUsage(AttributeTargets.Field)]
	public class Tooltip : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public Tooltip(string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	internal class CustomUpgradeSystemAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public CustomUpgradeSystemAttribute(string guid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	internal class DefaultAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DefaultAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DefaultAttribute(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DefaultAttribute(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DefaultAttribute(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DefaultAttribute(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DefaultAttribute(object enumValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DefaultAttribute([Optional] string defaultExpression)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DEPRECATED_NetworkComponentAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DEPRECATED_NetworkComponentAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DoNotGenerateComponentProperties : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public DoNotGenerateComponentProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	internal class FieldAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public FieldAttribute(int fieldNumber)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class NetworkComponentAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public NetworkComponentAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AttributeUsage(AttributeTargets.Enum)]
	internal class NetworkEnumAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public NetworkEnumAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[AttributeUsage(AttributeTargets.Struct)]
	internal class NetworkStructAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public NetworkStructAttribute(int version, bool isEditing = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Enum)]
	internal class RangeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public RangeAttribute(object min, object max)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class RegisterComponentDefault : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public RegisterComponentDefault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public class SingletonComponent : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public SingletonComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	internal class RRGuidAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
		public RRGuidAttribute(string guid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AttributeUsage(AttributeTargets.Struct)]
	public class RuntimeOnlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public RuntimeOnlyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SourceGenerate : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public SourceGenerate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class StableTypeHashAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public StableTypeHashAttribute(ulong typeHash, uint version = 0u)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[AttributeUsage(AttributeTargets.Struct)]
	public class SwatchPrimaryKeyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public SwatchPrimaryKeyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Interface)]
	internal class TombstonedFieldsAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public TombstonedFieldsAttribute(params int[] fieldIndices)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	internal class TombstonedVersionedTypeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public TombstonedVersionedTypeAttribute(string versionedTypeGuid)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AttributeUsage(AttributeTargets.Method)]
	internal class UpgradeFromVersionAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public UpgradeFromVersionAttribute(int oldVersion)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[AttributeUsage(AttributeTargets.Class)]
	internal class UpgraderAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public UpgraderAttribute(Type type)
		{
		}
	}
}
namespace RecRoom.DataLayer.Registration
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class AlignUtility
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private struct AlignOfHelper<T> where T : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public byte dummy;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public T data;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xB16190", Offset = "0xB15590", VA = "0x180B16190")]
		public static int AlignOf<T>() where T : struct
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Obfuscation]
	public abstract class AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public virtual string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public virtual void SetServiceCategoryIndices(List<int> indices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "6")]
		public virtual void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		public virtual void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "8")]
		public virtual void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "9")]
		public virtual void RegisterComponentDefaults(IComponentDefaultRegistration registration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3292220", Offset = "0x3291620", VA = "0x183292220")]
		protected void RegisterComponentDefault<T>(IComponentDefaultRegistration registration, [In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77A0400", Offset = "0x779F800", VA = "0x1877A0400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77A0690", Offset = "0x779FA90", VA = "0x1877A0690")]
		protected AssemblyIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[AttributeUsage(AttributeTargets.Assembly)]
	public class HasAssemblyIndex : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public HasAssemblyIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface IComponentDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterComponentDefault(Type type, int alignment, Span<byte> data);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface IServiceRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CanBind(Type bindType, [Out] Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Register(Type bindType, Lifetime lifetime, object instance);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ulong CanBindAny(Type[] bindTypes, [Out] Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Register(Type[] bindTypes, Lifetime lifetime, ulong mask, object instance);
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface ITypeRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RegisterTypes(Type attribute, params Type[] types);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RegisterMethods(Type attribute, params Delegate[] delegates);
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct ServiceBitset : IComparable<ServiceBitset>, IEquatable<ServiceBitset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal uint first;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal uint second;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77A0C90", Offset = "0x77A0090", VA = "0x1877A0C90")]
		public static ServiceBitset Create()
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77A0C60", Offset = "0x77A0060", VA = "0x1877A0C60", Slot = "4")]
		public int CompareTo(ServiceBitset other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x77A0D70", Offset = "0x77A0170", VA = "0x1877A0D70", Slot = "5")]
		public bool Equals(ServiceBitset other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77A0CA0", Offset = "0x77A00A0", VA = "0x1877A0CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77A07B0", Offset = "0x779FBB0", VA = "0x1877A07B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x77A0FB0", Offset = "0x77A03B0", VA = "0x1877A0FB0")]
		public static ServiceBitset operator |(ServiceBitset a, ServiceBitset b)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x77A0DB0", Offset = "0x77A01B0", VA = "0x1877A0DB0")]
		public static ServiceBitset From(int[] localIndices, List<int> globalFromLocalIndices)
		{
			return default(ServiceBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77A0E70", Offset = "0x77A0270", VA = "0x1877A0E70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class ServiceBitsetExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x77A07B0", Offset = "0x779FBB0", VA = "0x1877A07B0")]
		public static int GetHashCode([In] ServiceBitset a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77A0780", Offset = "0x779FB80", VA = "0x1877A0780")]
		public static int CompareTo([In] ServiceBitset a, [In] ServiceBitset b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77A0820", Offset = "0x779FC20", VA = "0x1877A0820")]
		public static bool HasNone([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x77A07F0", Offset = "0x779FBF0", VA = "0x1877A07F0")]
		public static bool HasAny([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x77A07C0", Offset = "0x779FBC0", VA = "0x1877A07C0")]
		public static bool HasAll([In] this ServiceBitset a, [In] ServiceBitset b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x77A0880", Offset = "0x779FC80", VA = "0x1877A0880")]
		public static void Or([In] this ServiceBitset a, [In] ServiceBitset b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x77A0850", Offset = "0x779FC50", VA = "0x1877A0850")]
		public static bool IsSet([In] this ServiceBitset bitset, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x77A0890", Offset = "0x779FC90", VA = "0x1877A0890")]
		public static void Set(this ServiceBitset bitset, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x680B2C0", Offset = "0x680A6C0", VA = "0x18680B2C0")]
		public static void ClearAll(this ServiceBitset bitset)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct ServiceBitsetFilter : IComparable<ServiceBitsetFilter>, IEquatable<ServiceBitsetFilter>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[Flags]
		public enum Mask
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			All = 1,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			Any = 2,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			None = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ServiceBitset all;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ServiceBitset any;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ServiceBitset none;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public Mask mask;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77A0C40", Offset = "0x77A0040", VA = "0x1877A0C40")]
		public ServiceBitsetFilter(ServiceBitset all, ServiceBitset any, ServiceBitset none, Mask mask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77A08D0", Offset = "0x779FCD0", VA = "0x1877A08D0", Slot = "4")]
		public int CompareTo(ServiceBitsetFilter other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x77A0BD0", Offset = "0x779FFD0", VA = "0x1877A0BD0")]
		public bool Matches([In] ServiceBitset bitset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x762E220", Offset = "0x762D620", VA = "0x18762E220")]
		public bool Has(Mask value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77A0A80", Offset = "0x779FE80", VA = "0x1877A0A80", Slot = "5")]
		public bool Equals(ServiceBitsetFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x77A09D0", Offset = "0x779FDD0", VA = "0x1877A09D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x77A0B70", Offset = "0x779FF70", VA = "0x1877A0B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace RecRoom.DataLayer.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
	[Obfuscation(Exclude = true, ApplyToMembers = false)]
	public class AstarNavGraphType : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public AstarNavGraphType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	[Obfuscation(Exclude = true, ApplyToMembers = false)]
	public class RenderingVolumeComponentType : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public RenderingVolumeComponentType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Obfuscation(ApplyToMembers = false)]
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public PreserveAttribute()
		{
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

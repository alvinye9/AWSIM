namespace RGLUnityPlugin
{
	public enum RGLStatus
	{
		SUCCESS = 0,
		INVALID_ARGUMENT,
		INVALID_STATE,
		LOGGING_ERROR,
		INVALID_API_OBJECT,
		INVALID_PIPELINE,
		NOT_IMPLEMENTED = 404,
		INTERNAL_EXCEPTION = 500,
	};

	public enum RGLField
	{
		XYZ_F32 = 1,
		INTENSITY_F32,
		IS_HIT_I32,
		RAY_IDX_U32,
		POINT_IDX_U32,
		DISTANCE_F32,
		AZIMUTH_F32,
		RING_ID_U16,
		RETURN_TYPE_U8,
		TIME_STAMP_F64,
		// Dummy fields
		PADDING_8 = 1024,
		PADDING_16,
		PADDING_32,
		// Dynamic fields
		DYNAMIC_FORMAT = 13842,
	}
	
	public enum RGLLogLevel
	{
		ALL = 0,
		TRACE = 0,
		DEBUG = 1,
		INFO = 2,
		WARN = 3,
		ERROR = 4,
		CRITICAL = 5,
		OFF = 6,
	};
}
shader_type spatial;

uniform sampler2D depth_texture : hint_depth_texture;
uniform float scroll_speed = 0.1;
uniform float wave_height = 0.1;
uniform sampler2D noise_texture;
uniform sampler2D noise_normals;
uniform vec3 water_color : source_color = vec3(0,0,1.0);

void vertex() {
	UV = (TIME * scroll_speed + UV);

	NORMAL = NORMAL * texture(noise_normals, UV).rgb;
	vec3 tex = texture(noise_texture, UV).xyz;
	VERTEX.y += tex.y * wave_height;
}

void fragment() {
	float depth = texture(depth_texture, SCREEN_UV).r;
	vec3 foam_tex = texture(noise_texture, UV).rgb;

	depth = PROJECTION_MATRIX[3][2] / (depth + PROJECTION_MATRIX[2][2]);
	depth = VERTEX.z + depth;

	vec3 vec3_depth = vec3(depth*0.6);
	vec3 inv_vec3_depth = vec3(1.0  - vec3_depth.rgb);

	EMISSION = vec3(0, 0, 0.5);
	ROUGHNESS = 0.4;
	ALBEDO = mix(inv_vec3_depth, vec3(depth) * water_color, 0.7);
	ALBEDO = mix(foam_tex, ALBEDO, 0.8);
}
